using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Windows.Forms;


namespace _3IDM_Toolbar
{
    public partial class Form1 : Form
    {
        #region VARIABLES

        //Mode debug
        private readonly bool debog = false;

        //Dossiers communs
        readonly string Doc_publics = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
        readonly string Mes_docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        readonly string Program_Files = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles);
        readonly string Chemin_App = Application.StartupPath;
        readonly string Chemin_programmes = Path.Combine(Application.StartupPath, "Programmes/");

        //Dimensions fenêtre
        public int FEN_Largeur = 150;
        public int FEN_Hauteur = 700;

        //Dimensions bouton
        public int BT_Largeur = 20;
        public int BT_Hauteur = 120;

        //Configuration du bouton
        public int Decalage_bord = -2;


        //Internet
        public bool SrvLocal = false;
        public bool SrvDistant = true;

        #endregion

        #region CHARGEMENT
        public Form1()
        {
            this.InitializeComponent();
            this.Location=new Point(Screen.PrimaryScreen.WorkingArea.Width-this.Width+this.Decalage_bord, Screen.PrimaryScreen.WorkingArea.Height-this.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Position de la fenetre au démarrage
            this.Location=new Point(Screen.PrimaryScreen.WorkingArea.Width-this.Width+this.Decalage_bord,
                Screen.PrimaryScreen.WorkingArea.Height-this.Height);

            //Modification de l'interface
            this.BT_Show.Visible=false;
            this.BT_Hide.Visible=true;
            this.BackgroundImage=null;
            //this.Cursor=new Cursor(GetType(), "Curseur_MCAM1.png");
            this.Width=this.FEN_Largeur;
            this.Height=this.FEN_Hauteur;

            //Affichage de l'adresse IP courante
            this.LBL_IP.Text=GetLocalIPAddress();

            //Affichage de la version actuelle de l'utilitaire
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            this.LBL_Version.Text="Version : "+version.ToString();

            //Démarrage du timer pour le controle d'acces à Internet
            this.Timer_CheckInternet.Start();

            #region Tooltips

            //Visibles
            this.TT_01.SetToolTip(this.BT_Hide, "Cacher la barre 3IDM");
            this.TT_01.SetToolTip(this.LBL_IP, "Adresse IP actuelle");
            this.TT_01.SetToolTip(this.BT_CimcoEdit, "Lance l'éditeur CIMCO");
            this.TT_01.SetToolTip(this.BT_CodeExpert, "Lance l'éditeur CODE EXPERT");
            this.TT_01.SetToolTip(this.BT_Teamviewer, "Lance TeamViewer");
            this.TT_01.SetToolTip(this.BT_SMCAM_2021, "Ouvre le dossier My MasterCAM 2021");
            this.TT_01.SetToolTip(this.BT_SMCAM_2022, "Ouvre le dossier My MasterCAM 2022");
            this.TT_01.SetToolTip(this.BT_SMCAM_2023, "Ouvre le dossier My MasterCAM 2023");
            this.TT_01.SetToolTip(this.BT_MMCAM_2021, "Ouvre le dossier Shared MasterCAM 2021");
            this.TT_01.SetToolTip(this.BT_MMCAM_2022, "Ouvre le dossier Shared MasterCAM 2022");
            this.TT_01.SetToolTip(this.BT_MMCAM_2023, "Ouvre le dossier Shared MasterCAM 2023");
            this.TT_01.SetToolTip(this.RB_ServLocal, "Bascule sur la connexion LOCALE au serveur 3IDM");
            this.TT_01.SetToolTip(this.RB_ServDistant, "Bascule sur la connexion DISTANTE au serveur 3IDM");
            this.TT_01.SetToolTip(this.BT_Serveur3IDM, "Connexion à la base");

            //Invisibles
            this.TT_01.SetToolTip(this.BT_Show, "Affiche la barre 3IDM");

            #endregion
        }

        #endregion

        #region ROUTINES

        //Remonte l'adresse IP courante
        public static string GetLocalIPAddress()

        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily==AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Pas d'adaptateur trouvé !");
        }
        public void Cacher_menu()

        //Cache la barre
        {
            this.GPB_Infos.Visible=false;
            this.GPB_SMCAM.Visible=false;
            this.GPB_MMCAM2.Visible=false;
            this.GPB_Utilitaire.Visible=false;

            this.BT_Serveur3IDM.Visible=false;

            this.Size=new Size(this.BT_Largeur, this.BT_Hauteur);
            this.Location=new Point(Screen.PrimaryScreen.WorkingArea.Width-this.Width, Screen.PrimaryScreen.WorkingArea.Height-this.Height);
            this.BT_Hide.Visible=false;
            this.BT_Show.Visible=true;

            this.BackgroundImageLayout=ImageLayout.Stretch;

            this.LBL_Version.Visible=false;
        }
        public void Montrer_menu()

        //Montre la barre
        {
            this.GPB_Infos.Visible=true;
            this.GPB_SMCAM.Visible=true;
            this.GPB_MMCAM2.Visible=true;
            this.GPB_Utilitaire.Visible=true;

            this.BT_Serveur3IDM.Visible=true;

            this.Size=new Size(this.BT_Largeur, this.BT_Hauteur);
            this.Location=new Point(Screen.PrimaryScreen.WorkingArea.Width-this.Width, Screen.PrimaryScreen.WorkingArea.Height-this.Height);
            this.BT_Hide.Visible=true;
            this.BT_Show.Visible=false;

            this.Size=new Size(this.FEN_Largeur, this.FEN_Hauteur);
            this.Location=new Point(Screen.PrimaryScreen.WorkingArea.Width-this.Width+this.Decalage_bord, Screen.PrimaryScreen.WorkingArea.Height-this.Height);

            this.BackgroundImage=null;

            this.LBL_Version.Visible=true;
        }

        //Timer controle acces Internet
        public bool Timer_CheckInternet_Tick(object sender, EventArgs e)


        {
            try
            {
                using (WebClient client = new WebClient())
                using (Stream stream = client.OpenRead("http://www.google.fr"))
                {
                    return true;
                    //this.PB_InternetCheck.BackgroundImage=Barre_3IDM.Properties.Resources.OK;
                    //this.BT_Serveur3IDM.Enabled=true;

                }
            }
            catch
            {
                return false;
                //this.PB_InternetCheck.BackgroundImage=Barre_3IDM.Properties.Resources.NOK;
                //this.BT_Serveur3IDM.Enabled=false;
            }
        }

        #endregion

        #region CONTROLES

        #region Boutons affichage + fermer

        //Bouton pour cacher la barre
        private void BT_Hide_Click(object sender, EventArgs e)

        {
            this.Cacher_menu();
        }
        //Bouton pour afficher la barre
        private void BT_Show_Click(object sender, EventArgs e)

        {
            this.Montrer_menu();
        }

        //Fermer l'application
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        #region Utiliaires
        //Lance CIMCO EDIT
        private void BT_CimcoEdit_Click(object sender, EventArgs e)
        {
            Process.Start("C:/Program Files/Mastercam 2022/Mastercam/common/Editors/CIMCOEdit8/CIMCOEdit.exe");
        }

        //Lance CODE EXPERT
        private void BT_CodeExpert_Click(object sender, EventArgs e)
        {
            Process.Start("C:/Program Files/Mastercam 2022/Mastercam/Extensions/CodeExpert.exe");
        }

        //Lance TeamViewer
        private void BT_Teamviewer_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Chemin_programmes+"TV_QS.exe");
            Process.Start(this.Chemin_programmes+"TV_QS.exe");
        }
        #endregion

        #region My MasterCAM
        //Ouvre le dossier My MasterCAM 2023
        private void BT_SMCAM_2023_Click(object sender, EventArgs e)

        {
            string CHE_MMcam2023 = Path.Combine(this.Mes_docs, "My Mastercam 2023");

            try
            {
                if (Directory.Exists(CHE_MMcam2023))
                {
                    if (this.debog==true)
                    {
                        MessageBox.Show(CHE_MMcam2023);
                    }
                    Process.Start(CHE_MMcam2023);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Le dossier My Mastercam 2023 n'a pas été trouvé, voulez-vous le créer ?", "Avertissement",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result==DialogResult.Yes)
                    {
                        DirectoryInfo folder = Directory.CreateDirectory(Path.Combine(this.Mes_docs, "My Mastercam 2023"));
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {

            }
        }

        //Ouvre le dossier My MasterCAM 2022
        private void BT_SMCAM_2022_Click(object sender, EventArgs e)
        {
            {
                string CHE_MMcam2022 = Path.Combine(this.Mes_docs, "My Mastercam 2022");

                try
                {
                    if (Directory.Exists(CHE_MMcam2022))
                    {
                        if (this.debog==true)
                        {
                            MessageBox.Show(CHE_MMcam2022);
                        }
                        Process.Start(CHE_MMcam2022);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Le dossier My Mastercam 2022 n'a pas été trouvé, voulez-vous le créer ?", "Avertissement",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result==DialogResult.Yes)
                        {
                            DirectoryInfo folder = Directory.CreateDirectory(Path.Combine(this.Mes_docs, "My Mastercam 2022"));
                        }
                        else
                        {

                        }
                    }
                }
                catch (Exception)
                {

                }
                finally
                {

                }
            }
        }

        //Ouvre le dossier My MasterCAM 2021
        private void BT_SMCAM_2021_Click(object sender, EventArgs e)
        {
            {
                string CHE_MMcam2021 = Path.Combine(this.Mes_docs, "My Mastercam 2021");

                try
                {
                    if (Directory.Exists(CHE_MMcam2021))
                    {
                        if (this.debog==true)
                        {
                            MessageBox.Show(CHE_MMcam2021);
                        }
                        Process.Start(CHE_MMcam2021);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Le dossier My Mastercam 2021 n'a pas été trouvé, voulez-vous le créer ?", "Avertissement",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result==DialogResult.Yes)
                        {
                            DirectoryInfo folder = Directory.CreateDirectory(Path.Combine(this.Mes_docs, "My Mastercam 2021"));
                        }
                        else
                        {

                        }
                    }
                }
                catch (Exception)
                {

                }
                finally
                {

                }
            }
        }
        #endregion

        #region Shared MasterCAM

        //Ouvre le dossier Shared MasterCAM 2021
        private void BT_MMCAM_2021_Click(object sender, EventArgs e)


        {
            string CHE_SMcam2021 = Path.Combine(this.Doc_publics, "Shared Mastercam 2021");

            try
            {
                if (Directory.Exists(CHE_SMcam2021))
                {
                    if (this.debog==true)
                    {
                        MessageBox.Show(CHE_SMcam2021);
                    }
                    Process.Start(CHE_SMcam2021);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Le dossier Shared Mastercam 2021 n'a pas été trouvé, voulez-vous le créer ?",
                        "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result==DialogResult.Yes)
                    {
                        DirectoryInfo folder = Directory.CreateDirectory(Path.Combine(this.Doc_publics, "Shared Mastercam 2021"));
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {

            }
        }

        //Ouvre le dossier Shared MasterCAM 2022
        private void BT_MMCAM_2022_Click(object sender, EventArgs e)
        {
            string CHE_SMcam2022 = Path.Combine(this.Doc_publics, "Shared Mastercam 2022");

            try
            {
                if (Directory.Exists(CHE_SMcam2022))
                {
                    if (this.debog==true)
                    {
                        MessageBox.Show(CHE_SMcam2022);
                    }
                    Process.Start(CHE_SMcam2022);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Le dossier Shared Mastercam 2022 n'a pas été trouvé, voulez-vous le créer ?",
                        "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result==DialogResult.Yes)
                    {
                        DirectoryInfo folder = Directory.CreateDirectory(Path.Combine(this.Doc_publics, "Shared Mastercam 2022"));
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {

            }
        }

        //Ouvre le dossier Shared MasterCAM 2023
        private void BT_MMCAM_2023_Click(object sender, EventArgs e)
        {
            string CHE_SMcam2023 = Path.Combine(this.Doc_publics, "Shared Mastercam 2023");

            try
            {
                if (Directory.Exists(CHE_SMcam2023))
                {
                    if (this.debog==true)
                    {
                        MessageBox.Show(CHE_SMcam2023);
                    }
                    Process.Start(CHE_SMcam2023);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Le dossier Shared Mastercam 2023 n'a pas été trouvé, voulez-vous le créer ?", "Avertissement",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result==DialogResult.Yes)
                    {
                        DirectoryInfo folder = Directory.CreateDirectory(Path.Combine(this.Doc_publics, "Shared Mastercam 2023"));
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {

            }
        }
        #endregion

        #region Serveur 3IDM

        //Selection connexion serveur 3IDM Distant
        private void RB_ServDistant_CheckedChanged(object sender, EventArgs e)

        {
            if (this.RB_ServDistant.Checked==true)
            {
                this.SrvDistant=true;
            }
            else
            {
                this.SrvDistant=false;
            }
        }

        //Selection connexion serveur 3IDM Local
        private void RB_ServLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RB_ServLocal.Checked==true)
            {
                this.SrvLocal=true;
            }
            else
            {
                this.SrvLocal=false;
            }
        }

        //Connexion au serveur 3IDM, selon la méthode sélectionée
        private void BT_Serveur3IDM_Click(object sender, EventArgs e)

        {
            if (this.SrvDistant==true)
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.FileName="MSTSC.exe";
                proc.Arguments="/v:"+"80.13.88.102:33890";
                Process.Start(proc);
            }
            else
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.FileName="MSTSC.exe";
                proc.Arguments="/v:"+"192.168.1.250";
                Process.Start(proc);
            }
        }



        #endregion

        #endregion

    }

}


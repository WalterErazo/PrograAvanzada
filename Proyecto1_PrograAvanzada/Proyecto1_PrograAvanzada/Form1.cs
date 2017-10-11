using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_PrograAvanzada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Congreso Goathemala = new Congreso();
        Parlamentario TempPar;
        Asesor TempAse;
        string Act_Name;
        string Act_Password;
        string Act_Work;


        //---------------------------LogIn---------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            A.SelectTab(1);
        }//cambia a pestaña CreateANewUser
        private void button2_Click(object sender, EventArgs e)
        {
            Act_Name = LogIn_User_txt.Text;
            try
            {
                Act_Password = SearchUserPassword(Act_Name);
                Act_Work = SearchUserWork(Act_Name);
            }
            catch
            {
            }
            if (Act_Password == LogIn_Password_txt.Text)
            {
                if (Act_Work == "Parlamentario")
                {
                    TempPar = this.SearchParlamentario();
                }
                else
                {
                    TempAse = this.SearchAsesor();
                }
                LogIn_Password_txt.Text = "";
                LogIn_User_txt.Text = "";
                A.SelectTab(2);
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos");
            }
        }//Hace el login
        //---------------------------LogIn---------------------------------------

        //---------------------------CreateANewUser---------------------------------------
        private void CreateANewUser_Create_buttom_Click(object sender, EventArgs e)
        {

            if (CreateANewUser_password_txt.Text == CreateANewUser_ConfirmPassword_txt.Text && CreateANewUser_password_txt.Text != "")
            {
                Act_Work = CreateANewUser_Work_Combobox.Text;
                if (Act_Work == "Parlamentario")
                {
                    try
                    {
                        TempPar = new Parlamentario(CreateANewUser_Name_txt.Text, int.Parse(CreateANewUser_Age_txt.Text), CreateANewUser_Sex_Combobox.Text, CreateANewUser_password_txt.Text);
                        Goathemala.addParlamentario(TempPar);
                        ClearCreateANewUser();
                        A.SelectTab(2);
                    }
                    catch
                    {
                        MessageBox.Show("Ingrese datos validos");
                    }
                }
                else
                {
                    try
                    {
                        TempAse = new Asesor(CreateANewUser_Name_txt.Text, int.Parse(CreateANewUser_Age_txt.Text), CreateANewUser_Sex_Combobox.Text, CreateANewUser_password_txt.Text);
                        if (AsociarAParlamentario(CreateANEwUser_AsociatedP_txt.Text, TempAse) == 0)
                        {
                            ClearCreateANewUser();
                            A.SelectTab(2);
                        }
                        else
                        {
                            MessageBox.Show("El asesor que usted nos indico no existe");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ingrese datos validos");
                    }
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas deven coincidir");
            }
        }//Crea el usuario
        //---------------------------CreateANewUser---------------------------------------


        //---------------------------Principal---------------------------------------
        private void Principal_Laws_Buttom_Click(object sender, EventArgs e)
        {
            A.SelectTab(5);
        }
        private void Principal_Regulations_Buttom_Click(object sender, EventArgs e)
        {
            A.SelectTab(10);
        }
        private void Principal_User_Buttom_Click(object sender, EventArgs e)
        {
            A.SelectTab(3);
            if (Act_Work == "Parlamentario")
            {
                UserDetails_Name_txt.Text = TempPar.ReturnName();
                UserDetails_Age_txt.Text = Convert.ToString(TempPar.ReturnAge());
                UserDetails_Sex_txt.Text = TempPar.ReturnSex();
                UserDetails_Password_txt.Text = TempPar.ReturnPassword();
                UserDetails_Work_txt.Text = "Parlamentario";
            }
            else
            {
                UserDetails_Name_txt.Text = TempAse.ReturnName();
                UserDetails_Age_txt.Text = Convert.ToString(TempAse.ReturnAge());
                UserDetails_Sex_txt.Text = TempAse.ReturnSex();
                UserDetails_Password_txt.Text = TempAse.ReturnPassword();
                UserDetails_Work_txt.Text = "Asesor";
            }
        }
        private void Principal_Exit_Buttom_Click(object sender, EventArgs e)
        {
            A.SelectTab(0);
            if (Act_Work == "Parlamentario")
            {
                TempPar = null;
            }
            else
            {
                TempAse = null;
            }
            Act_Name = "";
            Act_Password = "";
            Act_Work = "";

        }
        //---------------------------Principal---------------------------------------


        //---------------------------UserDetails---------------------------------------
        private void UserDetails_Back_Buttom_Click(object sender, EventArgs e)
        {
            A.SelectTab(2);
        }//regresa a la principal
        private void UserDetails_SeeGroup_Buttom_Click(object sender, EventArgs e)
        {
            A.SelectTab(4);
            if (Act_Work == "Parlamentario")
            {
                GroupUser_Par_Txt.Text = TempPar.ReturnName();
            }
            else
            {
                TempPar = Goathemala.getParlamentarioConUnAsesor(TempAse.ReturnName());
                GroupUser_Par_Txt.Text = TempPar.ReturnName();
            }
            GroupUser_AS1_txt.Text = TempPar.listadoDeAsesores(0).ReturnName();
            GroupUser_AS2_txt.Text = TempPar.listadoDeAsesores(1).ReturnName();
            GroupUser_AS3_txt.Text = TempPar.listadoDeAsesores(2).ReturnName();
            GroupUser_AS4_txt.Text = TempPar.listadoDeAsesores(3).ReturnName();
            GroupUser_AS5_txt.Text = TempPar.listadoDeAsesores(4).ReturnName();
            GroupUser_AS6_txt.Text = TempPar.listadoDeAsesores(5).ReturnName();
            GroupUser_AS7_txt.Text = TempPar.listadoDeAsesores(6).ReturnName();
            GroupUser_AS8_txt.Text = TempPar.listadoDeAsesores(7).ReturnName();
            if (Act_Work == "Asesor")
            {
                GroupUser_X1_Buttom.Enabled = false;
                GroupUser_X2_Buttom.Enabled = false;
                GroupUser_X3_Buttom.Enabled = false;
                GroupUser_X4_Buttom.Enabled = false;
                GroupUser_X5_Buttom.Enabled = false;
                GroupUser_X6_Buttom.Enabled = false;
                GroupUser_X7_Buttom.Enabled = false;
                GroupUser_X8_Buttom.Enabled = false;
            }
            else
            {
                GroupUser_X1_Buttom.Enabled = true;
                GroupUser_X2_Buttom.Enabled = true;
                GroupUser_X3_Buttom.Enabled = true;
                GroupUser_X4_Buttom.Enabled = true;
                GroupUser_X5_Buttom.Enabled = true;
                GroupUser_X6_Buttom.Enabled = true;
                GroupUser_X7_Buttom.Enabled = true;
                GroupUser_X8_Buttom.Enabled = true;
            }
        }//Ingresa a GroupUser
         //---------------------------UserDetails---------------------------------------


        //---------------------------GroupUser---------------------------------------
        private void button11_Click(object sender, EventArgs e)
        {
            A.SelectTab(3);
        }//Regresa
        private void GroupUser_X1_Buttom_Click(object sender, EventArgs e)
        {
            TempPar.listadoDeAsesores(0).Remove();
            GroupUser_AS1_txt.Text = TempPar.listadoDeAsesores(0).ReturnName();
            ;
        }//Elimia Asesor
        private void GroupUser_X2_Buttom_Click(object sender, EventArgs e)
        {
            TempPar.listadoDeAsesores(1).Remove();
            GroupUser_AS2_txt.Text = TempPar.listadoDeAsesores(1).ReturnName();
        }//Elimia Asesor
        private void GroupUser_X3_Buttom_Click(object sender, EventArgs e)
        {
            TempPar.listadoDeAsesores(2).Remove();
            GroupUser_AS3_txt.Text = TempPar.listadoDeAsesores(2).ReturnName();
        }//Elimia Asesor
        private void GroupUser_X4_Buttom_Click(object sender, EventArgs e)
        {
            TempPar.listadoDeAsesores(3).Remove();
            GroupUser_AS4_txt.Text = TempPar.listadoDeAsesores(3).ReturnName();
        }//Elimia Asesor
        private void GroupUser_X5_Buttom_Click(object sender, EventArgs e)
        {
            TempPar.listadoDeAsesores(4).Remove();
            GroupUser_AS5_txt.Text = TempPar.listadoDeAsesores(4).ReturnName();
        }//Elimia Asesor
        private void GroupUser_X6_Buttom_Click(object sender, EventArgs e)
        {
            TempPar.listadoDeAsesores(5).Remove();
            GroupUser_AS6_txt.Text = TempPar.listadoDeAsesores(5).ReturnName();
        }//Elimia Asesor
        private void GroupUser_X7_Buttom_Click(object sender, EventArgs e)
        {
            TempPar.listadoDeAsesores(6).Remove();
            GroupUser_AS7_txt.Text = TempPar.listadoDeAsesores(6).ReturnName();
        }//Elimia Asesor
        private void GroupUser_X8_Buttom_Click(object sender, EventArgs e)
        {
            TempPar.listadoDeAsesores(7).Remove();
            GroupUser_AS8_txt.Text = TempPar.listadoDeAsesores(7).ReturnName();
        }//Elimia Asesor
         //---------------------------GroupUser---------------------------------------


        //---------------------------Laws---------------------------------------
        private void Law_SeeLaws_Buttom_Click(object sender, EventArgs e)
        {
            SeeLaws_Laws_Lbx.Items.Clear();
            A.SelectTab(6);
            for (int i = 0; i < Goathemala.GoathemalaLaws.Length; i++)
            {
                SeeLaws_Laws_Lbx.Items.Add("Ley # " + (i + 1));
                SeeLaws_Laws_Lbx.Items.Add(Goathemala.returnLaws(i).returnName());
                SeeLaws_Laws_Lbx.Items.Add(Goathemala.returnLaws(i).returnDescription());
                SeeLaws_Laws_Lbx.Items.Add("");
            }//Se imprimen todas las leyes
        }//See laws buttom
        private void Law_CreateLaw_Buttom_Click(object sender, EventArgs e)
        {
            A.SelectTab(7);
            CreateLaws_Name_txt.Text = "";
            CreateLaws_Description_txt.Text = "";
        }
        private void Law_DeleteLaw_Buttom_Click(object sender, EventArgs e)
        {
            A.SelectTab(8);
            for (int i = 0; i < Goathemala.GoathemalaLaws.Length; i++)
            {
                DeleteLaws_SelectLaw_Combobox.Items.Add(Goathemala.GoathemalaLaws[i].returnName());
            }
        }
        private void Law_RentLaw_Buttom_Click(object sender, EventArgs e)
        {
            A.SelectTab(9);
        }
        private void Law_Back_Buttom_Click(object sender, EventArgs e)
        {
            A.SelectTab(2);
        }//RegresaAlMain
         //---------------------------Laws---------------------------------------


        //---------------------------SeeLaws---------------------------------------
        private void SeeLaws_Back_Buttom_Click(object sender, EventArgs e)
        {
            A.SelectTab(5);
        }
        //---------------------------SeeLaws---------------------------------------


        //---------------------------CreateLaws---------------------------------------
        private void CreateLaws_Create_Buttom_Click(object sender, EventArgs e)
        {
            if (CreateLaws_Name_txt.Text != "" && CreateLaws_Description_txt.Text != "")
            {
                Ley newLey = new Ley(CreateLaws_Name_txt.Text, CreateLaws_Description_txt.Text);
                Goathemala.addLaw(newLey);
                newLey = null;
                CreateLaws_Name_txt.Text = "";
                CreateLaws_Description_txt.Text = "";
            }
            else
            {
                MessageBox.Show("Ingrese un nombre o una descripcion");
            }
        }//Crea una nueva ley
        private void CreateLaws_Back_Buttom_Click(object sender, EventArgs e)
        {
            A.SelectTab(5);
        }//Regresa al menu de leyes
         //---------------------------CreateLaws---------------------------------------


        //---------------------------DeleteLaws---------------------------------------
        private void DeleteLaws_Back_Buttom_Click(object sender, EventArgs e)
        {
            A.SelectTab(5);
        }//Regresa al menu de leyes
        private void DeleteLaws_Delete_Buttom_Click(object sender, EventArgs e)
        {

        }
        //---------------------------DeleteLaws---------------------------------------


        //---------------------------Rent/Return_Laws---------------------------------------

        //---------------------------Rent/Return_Laws---------------------------------------


        //---------------------------Regulations---------------------------------------

        //---------------------------Regulations---------------------------------------


        //---------------------------SeeRegulations---------------------------------------

        //---------------------------SeeRegulations---------------------------------------


        //---------------------------CreateRegulations---------------------------------------

        //---------------------------CreateRegulations---------------------------------------


        //---------------------------DeleteRegulations---------------------------------------

        //---------------------------DeleteRegulations---------------------------------------


        //---------------------------Rent/Return_Regulations---------------------------------------

        //---------------------------Rent/Return_Regulations---------------------------------------


        string SearchUserPassword(string Act_Name)
        {
            return Goathemala.BuscarUsuarioP(Act_Name);
        }//Busca la contraseña del usuario
        string SearchUserWork(string Act_Name)
        {
            return Goathemala.BuscarUsuarioW(Act_Name);
        }//Busca el trabajo del usuario
        Asesor SearchAsesor()
        {
            return Goathemala.SAsesor(Act_Name);
        }//Busca el objeto asesor
        Parlamentario SearchParlamentario()
        {
            return Goathemala.SParlamentario(Act_Name);
        }//Busca el objeto parlamentario
        int AsociarAParlamentario(string ParName, Asesor AS)
        {
            return Goathemala.AsociarAParlamentario(ParName, AS);
        }//Asocia un asesor a un parlamentario
        public void ClearCreateANewUser()
        {
            CreateANewUser_Name_txt.Text = "";
            CreateANewUser_Age_txt.Text = "";
            CreateANewUser_Sex_Combobox.Text = "";
            CreateANewUser_password_txt.Text = "";
            CreateANewUser_ConfirmPassword_txt.Text = "";
            CreateANewUser_Work_Combobox.Text = "";
            CreateANEwUser_AsociatedP_txt.Text = "";
        }//Limpia las casillas de CreateANewUser
    }
}
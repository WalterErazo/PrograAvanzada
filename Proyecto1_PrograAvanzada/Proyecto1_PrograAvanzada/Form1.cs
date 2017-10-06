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
        Goathemala.
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
            Act_Password = SearchUserPassword(Act_Name);
            Act_Work = SearchUserWork(Act_Name);
            if (Act_Password == LogIn_Password_txt.Text)
            {
                if (Act_Work == "Parlamentario")
                {
                    Parlamentario TempPar = this.SearchParlamentario();
                }
                else
                {
                    //Asesor TemAse = this.SearchAsesor();
                }
                A.SelectTab(2);
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos");
            }
        }
        //---------------------------LogIn---------------------------------------


        //---------------------------CreateANewUser---------------------------------------
        private void CreateANewUser_Create_buttom_Click(object sender, EventArgs e)
        {

            if (CreateANewUser_password_txt.Text == CreateANewUser_ConfirmPassword_txt.Text)
            {
                if (CreateANewUser_Work_Combobox.Text == "Parlamentario")
                {
                    Parlamentario newParlamentario = new Parlamentario(CreateANewUser_Name_txt.Text, int.Parse(CreateANewUser_Age_txt.Text), CreateANewUser_Sex_Combobox.Text, CreateANewUser_password_txt.Text);
                    Goathemala.addParlamentario(newParlamentario);
                    A.SelectTab(2);
                }
                else
                {
                    Asesor newAsesor = new Asesor(CreateANewUser_Name_txt.Text, int.Parse(CreateANewUser_Age_txt.Text), CreateANewUser_Sex_Combobox.Text, CreateANewUser_password_txt.Text);
                    AsociarAParlamentario(CreateANEwUser_AsociatedP_txt.Text, newAsesor);
                    A.SelectTab(2);
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas deven coinsidir");
            }
        }
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
        }
        private void Principal_Exit_Buttom_Click(object sender, EventArgs e)
        {
            A.SelectTab(0);
            //Falta cerrar sesion del usuario actual
        }
        //---------------------------Principal---------------------------------------


        //---------------------------UserDetails---------------------------------------
        //---------------------------UserDetails---------------------------------------


        //---------------------------GroupUser---------------------------------------
        //---------------------------GroupUser---------------------------------------


        //---------------------------Laws---------------------------------------
        //---------------------------Laws---------------------------------------


        //---------------------------SeeLaws---------------------------------------
        //---------------------------SeeLaws---------------------------------------


        //---------------------------CreateLaws---------------------------------------
        //---------------------------CreateLaws---------------------------------------


        //---------------------------DeleteLaws---------------------------------------
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
        }

        string SearchUserWork(string Act_Name)
        {
            return Goathemala.BuscarUsuarioW(Act_Name);
        }

        Parlamentario SearchParlamentario()
        {
            return Goathemala.SParlamentario(Act_Name);
        }

        Asesor SearchAsesor()
        {
            return Goathemala.SAsesor(Act_Name);
        }

        void AsociarAParlamentario(string ParName, Asesor AS)
        {
            Goathemala.AsociarAParlamentario(ParName, AS);
        }
    }
}
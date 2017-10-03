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
        string Act_Name;
        string Act_Work;
        string Act_Password;


        
        //---------------------------LogIn---------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            A.SelectTab(1);
        }//cambia a pestaña CreateANewUser


        private void button2_Click(object sender, EventArgs e)
        {
            Act_Name = LogIn_User_txt.Text;
            SearchUserPassword(Act_Name);
            if (Act_Password == LogIn_Password_txt.Text)
            {
                //crear usuario temporal que pisados
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
                }
                else
                {
                    Asesor newAsesor = new Asesor(CreateANewUser_Name_txt.Text, int.Parse(CreateANewUser_Age_txt.Text), CreateANewUser_Sex_Combobox.Text, CreateANewUser_password_txt.Text);
                }
                A.SelectTab(2);
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


        void SearchUserPassword(string Act_Name)
        {
            Act_Password = Goathemala.BuscarUsuario(Act_Name);
        }
    }
}
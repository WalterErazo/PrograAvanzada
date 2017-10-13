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
            CreateANewUser_Sex_Combobox.SelectedIndex = -1;
            CreateANewUser_Sex_Combobox.SelectedIndex = -1;
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
                SeeLaws_Laws_Lbx.Items.Add("Disponibles : " + Goathemala.returnLaws(i).Copies);
                SeeLaws_Laws_Lbx.Items.Add("");
            }//Se imprimen todas las leyes
        }//See laws buttom
        private void Law_CreateLaw_Buttom_Click(object sender, EventArgs e)
        {
            A.SelectTab(7);
            CreateLaws_Name_txt.Text = "";
            CreateLaws_Description_txt.Text = "";
        }//boton para ir a interfaz de crear leyes
        private void Law_DeleteLaw_Buttom_Click(object sender, EventArgs e)
        {
            A.SelectTab(8);
            DeleteLaws_SelectLaw_Combobox.Items.Clear();
            for (int i = 0; i < Goathemala.GoathemalaLaws.Length; i++)
            {
                DeleteLaws_SelectLaw_Combobox.Items.Add(Goathemala.GoathemalaLaws[i].returnName());
            }
        }
        private void Law_RentLaw_Buttom_Click(object sender, EventArgs e)
        {
            A.SelectTab(9);
            for (int i = 0; i < Goathemala.GoathemalaLaws.Length; i++)
            {
                RentLaws_ChooseLaw_Combobox.Items.Add(Goathemala.GoathemalaLaws[i].returnName());
            }//llenar el combo box con las leyes rentadas

            if (Act_Work == "Parlamentario")
            {
                for (int i = 0; i < TempPar.LeyesEnAlquiler.Length; i++)
                {
                    RentLaws_ReturnLaw_Combobox.Items.Add(TempPar.LeyesEnAlquiler[i].returnName());
                }
            }
            else
            {
                for (int i = 0; i < TempAse.LeyesEnAlquiler.Length; i++)
                {
                    RentLaws_ReturnLaw_Combobox.Items.Add(TempAse.LeyesEnAlquiler[i].returnName());
                }
            }
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
            DeleteLaws_SelectLaw_Combobox.SelectedIndex = -1;
        }//Regresa al menu de leyes
        private void DeleteLaws_Delete_Buttom_Click(object sender, EventArgs e)
        {
            if (DeleteLaws_SelectLaw_Combobox.Text != "")
            {
                Goathemala.DeleteLaw(DeleteLaws_SelectLaw_Combobox.Text);
                DeleteLaws_SelectLaw_Combobox.SelectedIndex = -1;
                DeleteLaws_SelectLaw_Combobox.Items.Clear();
                for (int i = 0; i < Goathemala.GoathemalaLaws.Length; i++)
                {
                    if (Goathemala.GoathemalaLaws.Length != 0)
                    {
                        DeleteLaws_SelectLaw_Combobox.Items.Add(Goathemala.GoathemalaLaws[i].returnName());
                    }
                }
            }
            else
            {
                MessageBox.Show("Deve seleccionar la ley que desea borrar");
            }
        }
        //---------------------------DeleteLaws---------------------------------------


        //---------------------------Rent/Return_Laws---------------------------------------
        private void RentLaws_Rent_Buttom_Click(object sender, EventArgs e)
        {
            Ley A = new Ley("", "");
            Goathemala.rentLaws(RentLaws_ChooseLaw_Combobox.Text, ref A);
            if (A.returnName() != "")
            {
                if (Act_Work == "Parlamentario")
                {
                    if (TempPar.Yalatiene(RentLaws_ChooseLaw_Combobox.Text) == false)
                    {
                        TempPar.AlquilarLey(A);
                    }
                    else
                    {
                        MessageBox.Show("Usted ya tiene esta ley alquilada");
                    }
                }
                else
                {
                    if (TempAse.Yalatiene(RentLaws_ChooseLaw_Combobox.Text) == false)
                    {
                        TempAse.AlquilarLey(A);
                    }
                    else
                    {
                        MessageBox.Show("Usted ya tiene esta ley alquilada");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar una ley");
            }
            RentLaws_ReturnLaw_Combobox.Items.Clear();
            //Se vuelven a llenar los combo box.
            if (Act_Work == "Parlamentario")
            {
                for (int i = 0; i < TempPar.LeyesEnAlquiler.Length; i++)
                {
                    RentLaws_ReturnLaw_Combobox.Items.Add(TempPar.LeyesEnAlquiler[i].returnName());
                }
            }
            else
            {
                for (int i = 0; i < TempAse.LeyesEnAlquiler.Length; i++)
                {
                    RentLaws_ReturnLaw_Combobox.Items.Add(TempAse.LeyesEnAlquiler[i].returnName());
                }
            }
            RentLaws_ChooseLaw_Combobox.SelectedIndex = -1;
        }//Renta una ley
        private void RentLaws_Return_Buttom_Click(object sender, EventArgs e)
        {
            Ley A = new Ley("", "");
            Goathemala.returnLaws(RentLaws_ReturnLaw_Combobox.Text, ref A);
            if (Act_Work == "Parlamentario")
            {
                TempPar.DevolverLey(A);
                RentLaws_ReturnLaw_Combobox.Items.Clear();
                for (int i = 0; i < TempPar.LeyesEnAlquiler.Length; i++)
                {
                    RentLaws_ReturnLaw_Combobox.Items.Add(TempPar.LeyesEnAlquiler[i].returnName());
                }
            }
            else
            {
                TempAse.DevolverLey(A);
                RentLaws_ReturnLaw_Combobox.Items.Clear();
                for (int i = 0; i < TempAse.LeyesEnAlquiler.Length; i++)
                {
                    RentLaws_ReturnLaw_Combobox.Items.Add(TempAse.LeyesEnAlquiler[i].returnName());
                }
            }
            RentLaws_ReturnLaw_Combobox.SelectedIndex = -1;
        }
        private void RentLaws_Back_Buttom_Click(object sender, EventArgs e)
        {
            A.SelectTab(5);
            RentLaws_ChooseLaw_Combobox.Items.Clear();
            RentLaws_ChooseLaw_Combobox.SelectedIndex = -1;
            RentLaws_ReturnLaw_Combobox.Items.Clear();
            RentLaws_ReturnLaw_Combobox.SelectedIndex = -1;

        }//Regresa
         //---------------------------Rent/Return_Laws---------------------------------------


        //---------------------------Regulations---------------------------------------
        private void Regulations_SeeRegulations_button_Click(object sender, EventArgs e)
        {
            SeeRegulation_Regulations_Listbox.Items.Clear();
            A.SelectTab(11);
            for (int i = 0; i < Goathemala.GoathemalaLaws.Length; i++)
            {
                SeeRegulation_Regulations_Listbox.Items.Add("Ley :" + Goathemala.GoathemalaLaws[i].returnName());
                for (int j = 0; j < Goathemala.GoathemalaLaws[i].Reglamentos.Length; j++)
                {
                    SeeRegulation_Regulations_Listbox.Items.Add("Reglamento # " + (j + 1));
                    SeeRegulation_Regulations_Listbox.Items.Add(Goathemala.GoathemalaLaws[i].Reglamentos[j].returnName());
                    SeeRegulation_Regulations_Listbox.Items.Add(Goathemala.GoathemalaLaws[i].Reglamentos[j].returnDescription());
                    SeeRegulation_Regulations_Listbox.Items.Add("Disponibles : " + Goathemala.GoathemalaLaws[i].Reglamentos[j].Copies);
                    SeeRegulation_Regulations_Listbox.Items.Add("");
                }
                SeeRegulation_Regulations_Listbox.Items.Add("");
            }//Se imprimen todos los reglamentos
        }
        private void Regulations_CreateRegulations_button_Click(object sender, EventArgs e)
        {
            A.SelectTab(12);
            CreateRegulation_Name_txt.Text = "";
            CreateRegulation_Associate_txt.Text = "";
            CreateRegulation_Description_txt.Text = "";
        }
        private void Regulations_DeleteRegulations_button_Click(object sender, EventArgs e)
        {

        }
        private void Regulations_RentRegulations_button_Click(object sender, EventArgs e)
        {
            RentRegulation_ReturnRegularion_comboBox.Items.Clear();
            RentRegulation_ChooseRegulation_comboBox.Items.Clear();
            A.SelectTab(14);
            for (int i = 0; i < Goathemala.GoathemalaLaws.Length; i++)
            {
                for (int j = 0; j < Goathemala.GoathemalaLaws[i].Reglamentos.Length; j++)
                {
                    RentRegulation_ChooseRegulation_comboBox.Items.Add(Goathemala.GoathemalaLaws[i].Reglamentos[j].returnName());
                }
            }//llenar el combo box con los reglamentos posibles a rentar

            if (Act_Work == "Parlamentario")
            {
                for (int i = 0; i < TempPar.ReglamentosEnAlquiler.Length; i++)
                {
                    RentRegulation_ReturnRegularion_comboBox.Items.Add(TempPar.ReglamentosEnAlquiler[i].returnName());
                }
            }
            else
            {
                for (int i = 0; i < TempAse.ReglamentosEnAlquiler.Length; i++)
                {
                    RentRegulation_ReturnRegularion_comboBox.Items.Add(TempAse.ReglamentosEnAlquiler[i].returnName());
                }
            }
        }
        private void Regulations_Back_button_Click(object sender, EventArgs e)
        {
            A.SelectTab(2);
        }
        //---------------------------Regulations---------------------------------------


        //---------------------------SeeRegulations---------------------------------------
        private void SeeRegulation_Back_Buttom_Click(object sender, EventArgs e)
        {
            A.SelectTab(10);
        }//Regresa al menu de reglamentos
        //---------------------------SeeRegulations---------------------------------------


        //---------------------------CreateRegulations---------------------------------------
        private void CreateRegulation_Create_Button_Click(object sender, EventArgs e)
        {
            if (Goathemala.ReturnNumberOfLaw(CreateRegulation_Associate_txt.Text) != -1 && CreateRegulation_Associate_txt.Text != "")
            {
                if (CreateRegulation_Name_txt.Text != "" && CreateRegulation_Description_txt.Text != "")
                {
                    Reglamento newReglamento = new Reglamento(CreateRegulation_Name_txt.Text, CreateRegulation_Description_txt.Text);
                    Goathemala.GoathemalaLaws[Goathemala.ReturnNumberOfLaw(CreateRegulation_Associate_txt.Text)].AddRegulation(newReglamento);
                    newReglamento = null;//despues de asignarlo se borra el reglamento
                    CreateRegulation_Name_txt.Text = "";
                    CreateRegulation_Associate_txt.Text = "";
                    CreateRegulation_Description_txt.Text = "";
                }
                else
                {
                    MessageBox.Show("Ingrese un nombre, una descripcion");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una ley valida");
            }
        }//Ya sirve :v
        private void CreateRegulation_Back_Button_Click(object sender, EventArgs e)
        {
            A.SelectTab(10);
        }//Regresa a la interfaz de reglamentos
        //---------------------------CreateRegulations---------------------------------------


        //---------------------------DeleteRegulations---------------------------------------
        private void DeleteRegulation_Delete_button_Click(object sender, EventArgs e)
        {

        }
        private void DeleteRegulation_Back_Button_Click(object sender, EventArgs e)
        {

        }
        //---------------------------DeleteRegulations---------------------------------------


        //---------------------------Rent/Return_Regulations---------------------------------------
        private void RentRegulation_RentRegulation_button_Click(object sender, EventArgs e)
        {
            Reglamento A = new Reglamento("", "");
            Goathemala.rentRegulation(RentRegulation_ChooseRegulation_comboBox.Text, ref A);
            if (A.returnName() != "")
            {
                if (Act_Work == "Parlamentario")
                {
                    if (TempPar.YalatieneReg(RentRegulation_ChooseRegulation_comboBox.Text) == false)
                    {
                        TempPar.AlquilarReglamento(A);
                    }
                    else
                    {
                        MessageBox.Show("Usted ya tiene esta ley alquilada");
                    }
                }
                else
                {
                    if (TempAse.YalatieneReg(RentLaws_ChooseLaw_Combobox.Text) == false)
                    {
                        TempAse.AlquilarReglamento(A);
                    }
                    else
                    {
                        MessageBox.Show("Usted ya tiene esta ley alquilada");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar un reglamento");
            }
            RentRegulation_ChooseRegulation_comboBox.SelectedIndex = -1;
            RentRegulation_ReturnRegularion_comboBox.Items.Clear();
            //Se vuelven a llenar los combo box.
            if (Act_Work == "Parlamentario")
            {
                for (int i = 0; i < TempPar.ReglamentosEnAlquiler.Length; i++)
                {
                    RentRegulation_ReturnRegularion_comboBox.Items.Add(TempPar.ReglamentosEnAlquiler[i].returnName());
                }
            }
            else
            {
                for (int i = 0; i < TempAse.ReglamentosEnAlquiler.Length; i++)
                {
                    RentRegulation_ReturnRegularion_comboBox.Items.Add(TempAse.ReglamentosEnAlquiler[i].returnName());
                }
            }
        }//Renta un reglamento
        private void RentRegulation_ReturnRegulation_button_Click(object sender, EventArgs e)
        {
            Reglamento A = new Reglamento("", "");
            Goathemala.returnRegulation(RentRegulation_ReturnRegularion_comboBox.Text, ref A);
            if (Act_Work == "Parlamentario")
            {
                TempPar.DevolverReglamento(A);
                RentRegulation_ReturnRegularion_comboBox.Items.Clear();
                for (int i = 0; i < TempPar.ReglamentosEnAlquiler.Length; i++)
                {
                    RentRegulation_ReturnRegularion_comboBox.Items.Add(TempPar.ReglamentosEnAlquiler[i].returnName());
                }
            }
            else
            {
                TempAse.DevolverReglamento(A);
                RentRegulation_ReturnRegularion_comboBox.Items.Clear();
                for (int i = 0; i < TempAse.ReglamentosEnAlquiler.Length; i++)
                {
                    RentRegulation_ReturnRegularion_comboBox.Items.Add(TempAse.LeyesEnAlquiler[i].returnName());
                }
            }
            RentRegulation_ReturnRegularion_comboBox.SelectedIndex = -1;
        }
        private void RentRegulation_Back_button_Click(object sender, EventArgs e)
        {
            A.SelectTab(10);
        }
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


/*   for acceder a los reglamentos de las leyes
     for (int i = 0; i < Goathemala.GoathemalaLaws.Length; i++)
     {
         for (int j = 0; j < Goathemala.GoathemalaLaws[i].Reglamentos.Length; j++)
         {








*/
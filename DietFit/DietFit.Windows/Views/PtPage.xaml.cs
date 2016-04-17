using DietFit.Common;
using DietFit.Controllers;
using DietFit.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace DietFit.Views
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class BasicPage1 : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        private CriarPlanoTreinoController controller;
        private Appl app;
        private Fisico userPlano;
        private bool dia1Clicked;
        private bool dia2Clicked;
        private bool dia3Clicked;
        private bool dia4Clicked;
        private bool dia5Clicked;
        private bool dia6Clicked;

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public BasicPage1()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        private void textBoxex44_Copy1_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void fillList()
        {
            foreach (Utilizador u in app.getUtilizadores())
            {
                if (!u.getIsnutricionista() && !u.getIspt())
                {
                    listBox.Items.Add(u.getUserName());
                }
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            controller = (CriarPlanoTreinoController)e.Parameter;
            app = controller.getApp();
            this.userPlano = new Fisico();
            fillList();
        }

       

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="Common.NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="Common.SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="Common.NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="Common.NavigationHelper.LoadState"/>
        /// and <see cref="Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.
        
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

      

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            controller.setUtilizador((String)listBox.SelectedItem);

            textPrim.Text = controller.getUser().getPnome();
            textObj.Text = controller.getUser().getObjetivo();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            controller.setPlano(this.userPlano);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            dia1Clicked = true;
            dia2Clicked=false;
            dia3Clicked = false; 
            dia4Clicked=false;
            dia5Clicked=false;
            dia6Clicked=false;
           
    }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            dia1Clicked = false;
            dia2Clicked = true;
            dia3Clicked = false; 
            dia4Clicked = false;
            dia5Clicked = false;
            dia6Clicked = false;
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
           
        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            List<Exercicio> exercicios = new List<Exercicio>();
            exercicios.Add(new Exercicio(textBoxex11.Text, textBoxs11.Text, textBoxzm11.Text));
            exercicios.Add(new Exercicio(textBoxex22.Text, textBoxs22.Text, textBoxzm22.Text));
            exercicios.Add(new Exercicio(textBoxex33.Text, textBoxs33.Text, textBoxzm33.Text));
            exercicios.Add(new Exercicio(textBoxex44.Text, textBoxs44.Text, textBoxzm44.Text));
            exercicios.Add(new Exercicio(textBoxex55.Text, textBoxs55.Text, textBoxzm55.Text));
            exercicios.Add(new Exercicio(textBoxex66.Text, textBoxs66.Text, textBoxzm66.Text));
            if (this.dia1Clicked)
            {
                this.userPlano.setDia1(exercicios);
            }
            else if (this.dia2Clicked)
            {
                this.userPlano.setDia2(exercicios);
            }
            else if (this.dia3Clicked)
            {
                this.userPlano.setDia3(exercicios);
            }
            else if (this.dia4Clicked)
            {
                this.userPlano.setDia4(exercicios);
            }
            else if (this.dia5Clicked)
            {
                this.userPlano.setDia5(exercicios);
            }
            else if (this.dia6Clicked)
            {
                this.userPlano.setDia6(exercicios);
            }
            textBoxex11.Text = "";
            textBoxzm11.Text = "";
            textBoxs11.Text = "";
            textBoxex22.Text = "";
            textBoxzm22.Text = "";
            textBoxs22.Text = "";
            textBoxex33.Text = "";
            textBoxzm33.Text = "";
            textBoxs33.Text = "";
            textBoxex44.Text = "";
            textBoxzm44.Text ="";
            textBoxs44.Text = "";
            textBoxex55.Text = "";
            textBoxzm55.Text = "";
            textBoxs55.Text = "";
            textBoxex66.Text = "";
            textBoxzm66.Text = "";
            textBoxs66.Text = "";
        }

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            dia1Clicked = false;
            dia2Clicked = false;
            dia3Clicked = true;
            dia4Clicked = false;
            dia5Clicked = false;
            dia6Clicked = false;
        }

        private void button4_Click_1(object sender, RoutedEventArgs e)
        {
            dia1Clicked = false;
            dia2Clicked = false;
            dia3Clicked = false;
            dia4Clicked = true;
            dia5Clicked = false;
            dia6Clicked = false;
        }

        private void button5_Click_1(object sender, RoutedEventArgs e)
        {
            dia1Clicked = false;
            dia2Clicked = false;
            dia3Clicked = false;
            dia4Clicked = false;
            dia5Clicked = true;
            dia6Clicked = false;
        }

        private void button6_Click_1(object sender, RoutedEventArgs e)
        {
            dia1Clicked = false;
            dia2Clicked = false;
            dia3Clicked = false;
            dia4Clicked = false;
            dia5Clicked = false;
            dia6Clicked = true;
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Historico), controller.getUser());
        }

        private void textObj_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.getUser().setPeso(Double.Parse(textBox5.Text));
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.getUser().setMassaM(Double.Parse(textBox.Text));
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.getUser().setImc(Double.Parse(textBox1.Text));
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.getUser().setMassaG(Double.Parse(textBox2.Text));
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.getUser().setMetablismo(Int32.Parse(textBox3.Text));
        }

        private void textBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.getUser().setIdadeM(Int32.Parse(textBox4.Text));
        }
    }
}

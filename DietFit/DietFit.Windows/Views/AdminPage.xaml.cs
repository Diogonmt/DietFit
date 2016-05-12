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
    public sealed partial class AdminPage : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        private CriarPlanoNutricionalController controller;
        private Appl app;
        private bool dieta1WasClicked = false;
        private bool dieta2WasClicked = false;
        private bool dieta3WasClicked = false;

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


        public AdminPage()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        private void fillList()
        {
            foreach (Utilizador u in app.getUtilizadores())
            {
                if (!u.getIsnutricionista()&&!u.getIspt())
                {
                    listBox.Items.Add(u.getUserName());
                }
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            controller = (CriarPlanoNutricionalController)e.Parameter;
            this.app = controller.getApp();
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

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            controller.setUtilizador((String) listBox.SelectedItem);
            if(listBox.SelectedItem != null)
            {
                if (dieta1WasClicked)
                {
                    Plano plano = new Plano();
                    plano.setPalmoço(textBox.Text);
                    plano.setLmanha(textBox1.Text);
                    plano.setAlmoço(textBox2.Text);
                    plano.setLtarde(textBox3.Text);
                    plano.setJantar(textBox4.Text);
                    plano.setCeia(textBox5.Text);

                    controller.plano1(plano);
               

                new Windows.UI.Popups.MessageDialog("Plano alimentar inserido");
                }
                else if (dieta2WasClicked)
                {
                    Plano plano2 = new Plano();
                    plano2.setPalmoço(textBox.Text);
                    plano2.setLmanha(textBox1.Text);
                    plano2.setAlmoço(textBox2.Text);
                    plano2.setLtarde(textBox3.Text);
                    plano2.setJantar(textBox4.Text);
                    plano2.setCeia(textBox5.Text);

                    controller.plano2(plano2);


                    new Windows.UI.Popups.MessageDialog("Plano alimentar inserido");
                }
                else if (dieta3WasClicked)
                {
                    Plano plano3 = new Plano();
                    plano3.setPalmoço(textBox.Text);
                    plano3.setLmanha(textBox1.Text);
                    plano3.setAlmoço(textBox2.Text);
                    plano3.setLtarde(textBox3.Text);
                    plano3.setJantar(textBox4.Text);
                    plano3.setCeia(textBox5.Text);

                    controller.plano3(plano3);


                    new Windows.UI.Popups.MessageDialog("Plano alimentar inserido");
                }
                 textBox.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

            }
            else
            {
                new Windows.UI.Popups.MessageDialog("Insira um utilizador");
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Utilizador user = app.getUtilizadorByUser((String)listBox.SelectedItem);
            controller.setUtilizador((String)listBox.SelectedItem);
            if (user != null)
            {
                this.textPrim.Text = user.getPnome();
                this.textPeso.Text = user.getPeso().ToString();
                this.textMm.Text = user.getMassaM().ToString();
                this.textMassaG.Text = user.getMassaG().ToString();
                this.textBlockIm.Text = user.getIdadeM().ToString();
                this.textObj.Text = user.getObjetivo();
            }
        }
        

        private void dieta1_Click(object sender, RoutedEventArgs e)
        {
            dieta1WasClicked = true;
            dieta2WasClicked = false;
            dieta3WasClicked = false;
        }

        private void dieta2_Click(object sender, RoutedEventArgs e)
        {
            dieta1WasClicked = false;
            dieta2WasClicked = true;
            dieta3WasClicked = false;
        }
        private void dieta3_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Historico), controller.getUtilizador());
        }

        private void buttonpL_Click(object sender, RoutedEventArgs e)
        {
            UtilizadorInfoController c = new UtilizadorInfoController(this.app, this.controller.getUtilizador());
            this.Frame.Navigate(typeof(Views.PlanoFisico), c);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.HistoricaDados), controller.getUtilizador());
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Utilizador[] args = new Utilizador[1];
            args[0] = controller.getUtilizador();
            this.Frame.Navigate(typeof(Views.Observacao), args);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.HistóricoAlimentar), controller.getUtilizador());
        }

        private void dieta3_Click_1(object sender, RoutedEventArgs e)
        {
            dieta1WasClicked = false;
            dieta2WasClicked = false;
            dieta3WasClicked = true;
        }
    }
}

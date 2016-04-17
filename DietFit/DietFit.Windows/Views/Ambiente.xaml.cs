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
    public sealed partial class Ambiente : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        private UtilizadorInfoController controller;
        private Utilizador user;
        private Plano plano;
        private Plano plano2;
        private Plano plano3;
        private bool dieta1Clicked;
        private bool dieta2Clicked;
        private bool dieta3Clicked;

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

        public Ambiente()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            controller = (UtilizadorInfoController)e.Parameter;

            user = controller.getUser();
            this.plano = user.getPlano();
            this.plano2 = user.getPlano2();
            this.plano3 = user.getPlano3();
            this.txt_Nome.Text = user.getPnome();
            this.txt_Altura.Text = user.getAltura().ToString();
            this.txt_Mail.Text = user.getMail();
            this.txt_Peso.Text = user.getPeso().ToString();
            this.txt_Objetivo.Text = user.getObjetivo();
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

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Logout_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Login), controller.getApp());
        }

        private void textBlock2_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock3_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void dietaN1_Click(object sender, RoutedEventArgs e)
        {
                
                this.textBlock.Text = plano.getPalmoço();
                this.textBlock1.Text = plano.getLmanha();
                this.textBlock2.Text = plano.getAlmoço();
                this.textBlock3.Text = plano.getLtarde();
                this.textBlock4.Text = plano.getJantar();
                this.textBlock5.Text = plano.getCeia();
        }

        private void dietaN2_Click(object sender, RoutedEventArgs e)
        {
           
            this.textBlock.Text = plano2.getPalmoço();
            this.textBlock1.Text = plano2.getLmanha();
            this.textBlock2.Text = plano2.getAlmoço();
            this.textBlock3.Text = plano2.getLtarde();
            this.textBlock4.Text = plano2.getJantar();
            this.textBlock5.Text = plano2.getCeia();
        }

        private void dietaN3_Click(object sender, RoutedEventArgs e)
        {
            
            this.textBlock.Text = plano3.getPalmoço();
            this.textBlock1.Text = plano3.getLmanha();
            this.textBlock2.Text = plano3.getAlmoço();
            this.textBlock3.Text = plano3.getLtarde();
            this.textBlock4.Text = plano3.getJantar();
            this.textBlock5.Text = plano3.getCeia();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Utilizador[] args = new Utilizador[1];
            args[0] = controller.getUser();
            this.Frame.Navigate(typeof(Views.Observacao), args);
        }
    }
}

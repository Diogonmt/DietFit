using DietFit.Common;
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
    public sealed partial class Historico : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        private Utilizador user;

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        private void textBoxex44_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public Historico()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        private void textBoxex44_Copy1_TextChanged(object sender, TextChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            user = (Utilizador)e.Parameter;
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Fisico plano =user.getPlanoAnterior();
            textBoxex11.Text = plano.pDia1()[0].getExercicio();
            textBoxzm11.Text = plano.pDia1()[0].getZonaMuscular();
            textBoxs11.Text = plano.pDia1()[0].getSeRep();
            textBoxex22.Text = plano.pDia1()[1].getExercicio();
            textBoxzm22.Text = plano.pDia1()[1].getZonaMuscular();
            textBoxs22.Text = plano.pDia1()[1].getSeRep();
            textBoxex33.Text = plano.pDia1()[2].getExercicio();
            textBoxzm33.Text = plano.pDia1()[2].getZonaMuscular();
            textBoxs33.Text = plano.pDia1()[2].getSeRep();
            textBoxex44.Text = plano.pDia1()[3].getExercicio();
            textBoxzm44.Text = plano.pDia1()[3].getZonaMuscular();
            textBoxs44.Text = plano.pDia1()[3].getSeRep();
            textBoxex55.Text = plano.pDia1()[4].getExercicio();
            textBoxzm55.Text = plano.pDia1()[4].getZonaMuscular();
            textBoxs55.Text = plano.pDia1()[4].getSeRep();
            textBoxex66.Text = plano.pDia1()[5].getExercicio();
            textBoxzm66.Text = plano.pDia1()[5].getZonaMuscular();
            textBoxs66.Text = plano.pDia1()[5].getSeRep();
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            Fisico plano = user.getPlanoAnterior();
            textBoxex11.Text = plano.pDia2()[0].getExercicio();
            textBoxzm11.Text = plano.pDia2()[0].getZonaMuscular();
            textBoxs11.Text = plano.pDia2()[0].getSeRep();
            textBoxex22.Text = plano.pDia2()[1].getExercicio();
            textBoxzm22.Text = plano.pDia2()[1].getZonaMuscular();
            textBoxs22.Text = plano.pDia2()[1].getSeRep();
            textBoxex33.Text = plano.pDia2()[2].getExercicio();
            textBoxzm33.Text = plano.pDia2()[2].getZonaMuscular();
            textBoxs33.Text = plano.pDia2()[2].getSeRep();
            textBoxex44.Text = plano.pDia2()[3].getExercicio();
            textBoxzm44.Text = plano.pDia2()[3].getZonaMuscular();
            textBoxs44.Text = plano.pDia2()[3].getSeRep();
            textBoxex55.Text = plano.pDia2()[4].getExercicio();
            textBoxzm55.Text = plano.pDia2()[4].getZonaMuscular();
            textBoxs55.Text = plano.pDia2()[4].getSeRep();
            textBoxex66.Text = plano.pDia2()[5].getExercicio();
            textBoxzm66.Text = plano.pDia2()[5].getZonaMuscular();
            textBoxs66.Text = plano.pDia2()[5].getSeRep();
        }

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            Fisico plano = user.getPlanoAnterior();
            textBoxex11.Text = plano.pDia3()[0].getExercicio();
            textBoxzm11.Text = plano.pDia3()[0].getZonaMuscular();
            textBoxs11.Text = plano.pDia3()[0].getSeRep();
            textBoxex22.Text = plano.pDia3()[1].getExercicio();
            textBoxzm22.Text = plano.pDia3()[1].getZonaMuscular();
            textBoxs22.Text = plano.pDia3()[1].getSeRep();
            textBoxex33.Text = plano.pDia3()[2].getExercicio();
            textBoxzm33.Text = plano.pDia3()[2].getZonaMuscular();
            textBoxs33.Text = plano.pDia3()[2].getSeRep();
            textBoxex44.Text = plano.pDia3()[3].getExercicio();
            textBoxzm44.Text = plano.pDia3()[3].getZonaMuscular();
            textBoxs44.Text = plano.pDia3()[3].getSeRep();
            textBoxex55.Text = plano.pDia3()[4].getExercicio();
            textBoxzm55.Text = plano.pDia3()[4].getZonaMuscular();
            textBoxs55.Text = plano.pDia3()[4].getSeRep();
            textBoxex66.Text = plano.pDia3()[5].getExercicio();
            textBoxzm66.Text = plano.pDia3()[5].getZonaMuscular();
            textBoxs66.Text = plano.pDia3()[5].getSeRep();
        }

        private void button4_Click_1(object sender, RoutedEventArgs e)
        {
            Fisico plano = user.getPlanoAnterior();
            textBoxex11.Text = plano.pDia4()[0].getExercicio();
            textBoxzm11.Text = plano.pDia4()[0].getZonaMuscular();
            textBoxs11.Text = plano.pDia4()[0].getSeRep();
            textBoxex22.Text = plano.pDia4()[1].getExercicio();
            textBoxzm22.Text = plano.pDia4()[1].getZonaMuscular();
            textBoxs22.Text = plano.pDia4()[1].getSeRep();
            textBoxex33.Text = plano.pDia4()[2].getExercicio();
            textBoxzm33.Text = plano.pDia4()[2].getZonaMuscular();
            textBoxs33.Text = plano.pDia4()[2].getSeRep();
            textBoxex44.Text = plano.pDia4()[3].getExercicio();
            textBoxzm44.Text = plano.pDia4()[3].getZonaMuscular();
            textBoxs44.Text = plano.pDia4()[3].getSeRep();
            textBoxex55.Text = plano.pDia4()[4].getExercicio();
            textBoxzm55.Text = plano.pDia4()[4].getZonaMuscular();
            textBoxs55.Text = plano.pDia4()[4].getSeRep();
            textBoxex66.Text = plano.pDia4()[5].getExercicio();
            textBoxzm66.Text = plano.pDia4()[5].getZonaMuscular();
            textBoxs66.Text = plano.pDia4()[5].getSeRep();
        }

        private void button5_Click_1(object sender, RoutedEventArgs e)
        {
            Fisico plano = user.getPlanoAnterior();
            textBoxex11.Text = plano.pDia5()[0].getExercicio();
            textBoxzm11.Text = plano.pDia5()[0].getZonaMuscular();
            textBoxs11.Text = plano.pDia5()[0].getSeRep();
            textBoxex22.Text = plano.pDia5()[1].getExercicio();
            textBoxzm22.Text = plano.pDia5()[1].getZonaMuscular();
            textBoxs22.Text = plano.pDia5()[1].getSeRep();
            textBoxex33.Text = plano.pDia5()[2].getExercicio();
            textBoxzm33.Text = plano.pDia5()[2].getZonaMuscular();
            textBoxs33.Text = plano.pDia5()[2].getSeRep();
            textBoxex44.Text = plano.pDia5()[3].getExercicio();
            textBoxzm44.Text = plano.pDia5()[3].getZonaMuscular();
            textBoxs44.Text = plano.pDia5()[3].getSeRep();
            textBoxex55.Text = plano.pDia5()[4].getExercicio();
            textBoxzm55.Text = plano.pDia5()[4].getZonaMuscular();
            textBoxs55.Text = plano.pDia5()[4].getSeRep();
            textBoxex66.Text = plano.pDia5()[5].getExercicio();
            textBoxzm66.Text = plano.pDia5()[5].getZonaMuscular();
            textBoxs66.Text = plano.pDia5()[5].getSeRep();
        }

        private void button6_Click_1(object sender, RoutedEventArgs e)
        {
            Fisico plano = user.getPlanoAnterior();
            textBoxex11.Text = plano.pDia6()[0].getExercicio();
            textBoxzm11.Text = plano.pDia6()[0].getZonaMuscular();
            textBoxs11.Text = plano.pDia6()[0].getSeRep();
            textBoxex22.Text = plano.pDia6()[1].getExercicio();
            textBoxzm22.Text = plano.pDia6()[1].getZonaMuscular();
            textBoxs22.Text = plano.pDia6()[1].getSeRep();
            textBoxex33.Text = plano.pDia6()[2].getExercicio();
            textBoxzm33.Text = plano.pDia6()[2].getZonaMuscular();
            textBoxs33.Text = plano.pDia6()[2].getSeRep();
            textBoxex44.Text = plano.pDia6()[3].getExercicio();
            textBoxzm44.Text = plano.pDia6()[3].getZonaMuscular();
            textBoxs44.Text = plano.pDia6()[3].getSeRep();
            textBoxex55.Text = plano.pDia6()[4].getExercicio();
            textBoxzm55.Text = plano.pDia6()[4].getZonaMuscular();
            textBoxs55.Text = plano.pDia6()[4].getSeRep();
            textBoxex66.Text = plano.pDia6()[5].getExercicio();
            textBoxzm66.Text = plano.pDia6()[5].getZonaMuscular();
            textBoxs66.Text = plano.pDia6()[5].getSeRep();
        }
    }
}

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
    public sealed partial class Login : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        private Appl app;

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


        public Login()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            try {
                this.app = (Appl)e.Parameter;
            }catch(InvalidCastException i)
            {
                if (app == null)
                {
                    this.app = new Appl();
                    Utilizador nutricionista = new Utilizador();
                    nutricionista.setPnome("nutricionista");
                    nutricionista.setPassword("1234");
                    nutricionista.setUsername("nutricionista");
                    nutricionista.setIsnutricionista(true);
                    this.app.addUser(nutricionista);
                    Utilizador pt = new Utilizador();
                    pt.setPnome("pt");
                    pt.setPassword("1234");
                    pt.setUsername("pt");
                    pt.setIspt(true);
                    this.app.addUser(pt);
                }
            }
        }

        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }


        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }
        

        private void CriarConta(object sender, RoutedEventArgs e)
        {
            CriarContaController controller = new CriarContaController(app);
            this.Frame.Navigate(typeof(CriarConta), controller);
        }

        private void Entrar(object sender, RoutedEventArgs e)
        {
            Utilizador u = app.getUtilizadorByUser(this.txtcaixa_User.Text);
            if (u == null)
            {
                //pop up user nao existe
            }
            else
            {
                if (u.getPassword().Equals(this.txtcaixa_Pwdr.Password))
                {
                    if (u.getIsnutricionista())
                    {
                        CriarPlanoNutricionalController cpnc = new CriarPlanoNutricionalController(app, u);
                        this.Frame.Navigate(typeof(Views.AdminPage), cpnc);
                    }
                    else if(u.getIspt())
                    {
                        CriarPlanoTreinoController cptc = new CriarPlanoTreinoController(app, u);
                        this.Frame.Navigate(typeof(Views.BasicPage1), cptc);
                    }
                    else {
                        UtilizadorInfoController uic = new UtilizadorInfoController(app, u);
                        this.Frame.Navigate(typeof(Views.Menu), uic);
                    }
                }
                else
                {
                    var dialog = new Windows.UI.Popups.MessageDialog("Palavras passe errada");
                }
            }
            }

        private void CommandBar_Opened(object sender, object e)
        {

        }

        private void Ajuda(object sender, RoutedEventArgs e)
        {
          //  this.Frame.Navigate((typeof(Views.Ajuda)));

        }
    }
}

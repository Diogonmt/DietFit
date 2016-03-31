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
    public sealed partial class CriarConta : Page
    {
        private Utilizador user;
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

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


        public CriarConta()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
            this.user = new Utilizador();
            comboBox_Copy1.Items.Add("Ganhar Peso");
            comboBox_Copy1.Items.Add("Manter Peso");
            comboBox_Copy1.Items.Add("Perder Peso");
            comboBox.Items.Add("0");
            comboBox.Items.Add("1");
            comboBox.Items.Add("2");
            comboBox.Items.Add("3");
            comboBox.Items.Add("4");
            comboBox.Items.Add("5");
            comboBox.Items.Add("6");
            comboBox.Items.Add("7");
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

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void btn_CriarConta_Click(object sender, RoutedEventArgs e)
        {
            if (tb_Pwd.Password != tb_PwdRepeat.Password)
            {
                textErro.Text=("Palavras passe não coincidem");
            }
            else if (tb_User.Text.Equals("") || tb_Nome.Text.Equals("") || tb_Apelido.Text.Equals("")
                || tb_Peso.Text.Equals("") || tb_Altura.Text.Equals("") || tb_Email.Text.Equals(""))
            {
                textErro.Text=("Não preecheu todos os campos");
            }
            else if (!tb_Email.Text.Contains("@") || !tb_Email.Text.Contains("."))
            {
                textErro.Text=("O campo do email não foi bem preenchido");
            }
            else if (Appl.getUtilizadorByMail(tb_Email.Text) != null)
            {
               textErro.Text=("Já existe uma conta com este email");
            }
            else if (Appl.getUtilizadorByUser(tb_User.Text) != null)
            {
                new Windows.UI.Popups.MessageDialog("Já existe uma conta com este username");
            }
           /* else if(comboBox.SelectedValue == null)
            {
                new Windows.UI.Popups.MessageDialog("Insira um objetivo");
            }*/
            else
            {
                var dialog = new Windows.UI.Popups.MessageDialog("Registo efetuado com sucesso");
                dialog.Commands.Add(new Windows.UI.Popups.UICommand("Fechar"));
                user.setPnome(this.tb_Nome.Text);
                user.setPassword(this.tb_Pwd.Password);
                user.setUsername(this.tb_User.Text);
                user.setAltura(Int32.Parse(this.tb_Altura.Text));
                user.setMail(this.tb_Email.Text);
                user.setObjetivo(this.comboBox_Copy1.SelectedItem.ToString());
                // user.setPeso(double.Parse(this.txt_Peso.Text, System.Globalization.CultureInfo.InvariantCulture)); 
                Appl.addUser(user);

                //dialog.ShowAsync();

                this.Frame.Navigate(typeof(Views.Login));
            }
        }

        private void comboBox_Copy1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox_Copy1_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

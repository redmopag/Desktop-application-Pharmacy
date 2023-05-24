using Pharmacy.Models;
using Pharmacy.Repositories.EnterRepository;
using Pharmacy.Views.EnterView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Presenters
{
    public class EnterPresenter
    {
        private IEnterView view;
        private IEnterRepository repository;

        public EnterPresenter(IEnterView view, IEnterRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.view.EnterEvent += CheckEnter;
            this.view.Show();
        }

        private void CheckEnter(object sender, EventArgs e)
        {
            var model = new EnterModel();
            model.Name = view.EnterName;
            model.Password = view.EnterPassword;

            try
            {
                new Common.ModelDataValidator().Validate(model);
                if (repository.checkPasswordByName(view.EnterName, view.EnterPassword))
                    view.IsSuccessful = true;
                else
                    view.Message = "Неверный логин или пароль";
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }
    }
}

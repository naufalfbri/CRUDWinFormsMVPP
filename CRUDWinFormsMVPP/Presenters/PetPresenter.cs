using CRUDWinFormsMVPP.Models;
using CRUDWinFormsMVPP.Views;
using MvpCrudApp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUDWinFormsMVPP.Presenters
{
    public class PetPresenter
    {
        private readonly IPetView view;
        private readonly IPetRepository repository;
        private readonly BindingSource petsBindingSource;
        private IEnumerable<PetModel> petList;

        public PetPresenter(IPetView view, IPetRepository repository)
        {
            this.petsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchPet;
            this.view.AddNewEvent += AddNewPet;
            this.view.EditEvent += LoadSelectedPetToEdit;
            this.view.SaveEvent += SavePet;
            this.view.DeleteEvent += DeleteSelectedPet;
            this.view.CancelEvent += CancelAction;

            this.view.SetPetListBindingSource(petsBindingSource);


            LoadAllPetList();

   
            this.view.Show();
        }

        private void LoadAllPetList()
        {
            petList = repository.GetAll();
            petsBindingSource.DataSource = petList;
        }

        private void SearchPet(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.view.SearchValue))
                petList = repository.GetAll();
            else
                petList = repository.GetByValue(this.view.SearchValue);

            petsBindingSource.DataSource = petList;
        }

        private void AddNewPet(object sender, EventArgs e)
        {
            view.IsEdit = false;
            CleanViewFields();
        }

        private void LoadSelectedPetToEdit(object sender, EventArgs e)
        {
            var pet = (PetModel)petsBindingSource.Current;
            if (pet == null) return;

            view.PetId = pet.Id.ToString();
            view.PetName = pet.Name;
            view.PetType = pet.Type;
            view.PetColour = pet.Colour;
            view.IsEdit = true;
        }

        private void SavePet(object sender, EventArgs e)
        {
            var model = new PetModel
            {
                Id = Convert.ToInt32(string.IsNullOrEmpty(view.PetId) ? "0" : view.PetId),
                Name = view.PetName,
                Type = view.PetType,
                Colour = view.PetColour
            };

            try
            {
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Data hewan berhasil diperbarui.";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Data hewan berhasil ditambahkan.";
                }
                view.IsSuccessful = true;
                LoadAllPetList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.PetId = "0";
            view.PetName = "";
            view.PetType = "";
            view.PetColour = "";
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void DeleteSelectedPet(object sender, EventArgs e)
        {
            try
            {
                var pet = (PetModel)petsBindingSource.Current;
                if (pet == null) return;

                repository.Delete(pet.Id);
                view.IsSuccessful = true;
                view.Message = "Data hewan berhasil dihapus.";
                LoadAllPetList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Gagal menghapus: " + ex.Message;
            }
        }
    }
}
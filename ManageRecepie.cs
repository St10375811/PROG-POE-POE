using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;




namespace PROG_POE_Part3
{// namespace PROG_POE_Part3 begin
    public class ManageRecepie
    {// ManageRecepie begin
        //declare a generic collection for recipe
        public List<Recipe> Recipes { get; private set; }
        //constructor
        public ManageRecepie()
        {//constructor begin
            //create a new recipe list object
            Recipes = new List<Recipe>();
        }//constructor end

        //constructor with parameter for the recipe class
        public void AddRecipe(Recipe recipe)
        {//constructor with parameters begin
            //Add the recipe to the list
            Recipes.Add(recipe);
        }//constructor with parameters end

        //Method to display the alphabetically sorted recipes
        public void DisplayAllRecipes(ListBox recipeListBox)
        {//DisplayAllRecipes begin
            recipeListBox.Items.Clear(); //clear the list box
            //sort the recipes
            var sortedRecipes = Recipes.OrderBy(r => r.Name).ToList();
            //display the recipes in a list
            //for each to access all 
            foreach (var recipe in sortedRecipes)
            {//foreach begin
                recipeListBox.Items.Add(recipe.Name);
            }//foreach end
        }//DisplayAllRecipes end

        //Method to display Recipe Details in a textblock
        public void DisplayRecipeDetails(Recipe recipe, TextBlock recipeDetailsTextBlock)
        {//DisplayRecipeDetail begin
            recipeDetailsTextBlock.Text = recipe.DisplayRecipe();
        }//DisplayRecipeDetail end

        //method to scale recipe by a factor selected by the user and passed as a parameter
        public void ScaleRecipe(Recipe recipe, double factor)
        {//ScaleRecipe begin
            //call the scaleRecipe method from recipe class
            recipe.ScaleRecipe(factor);
        }//ScaleRecipe end

        //ResetRecipe method to return recipe to its orginal state after being scaled
        public void ResetRecipe(Recipe recipe)
        {//ResetRecipe begin
            recipe.ResetRecipe();
        }//ResetRecipe end

        //Method to delete recupe the user selected by removing recipe from recipe list
        public void DeleteRecipe(Recipe recipe)
        {//DeleteRecipe begin
            if (Recipes.Contains(recipe))
            {//if recipe list contains the recipe user wants to delete begin
                Recipes.Remove(recipe);
                MessageBox.Show($"Recipe '{recipe.Name}' has been deleted.", "Delete Recipe", MessageBoxButton.OK, MessageBoxImage.Information);
            }//if recipe list contains the recipe user wants to delete end
            else
            {//else if recipe is not in the recipe list begin
                //Disply error message for recipe not found
                MessageBox.Show($"Recipe '{recipe.Name}' not found.", "Delete Recipe", MessageBoxButton.OK, MessageBoxImage.Error);
            }//else if recipe is not in the recipe list end
        }//DeleteRecipe end
    }// ManageRecepie end
}// namespace PROG_POE_Part3 end
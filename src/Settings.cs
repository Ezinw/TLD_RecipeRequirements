using ModSettings;
using System.Reflection;

namespace RecipeRequirements
{
    public class RecipeSkillSettings : JsonModSettings
    {
        [Section(" ")]
        
        [Name("Level 5 Cooking Recipes")]
        [Description("Show or hide level 5 cooking recipes")]
        [Choice("+", "-")]
        public bool recipe5 = false;

        [Name("                  - Pemmican Bar")]
        [Description("Set the required cooking skill level for the Pemmican Bar recipe.")]
        [Slider(1, 5)]
        public int barPemmican = 5;

        [Name("                  - Coastal Fishcakes")]
        [Description("Set the required cooking skill level for the  Coastal Fishcakes recipe.")]
        [Slider(1, 5)]
        public int fishcakes = 5;

        [Name("                  - Dockworker's Pie")]
        [Description("Set the required cooking skill level for the Dockworker's Pie recipe.")]
        [Slider(1, 5)]
        public int pieFishermans = 5;

        [Name("                  - Prepper's Pie")]
        [Description("Set the required cooking skill level for the  Prepper's Pie recipe.")]
        [Slider(1, 5)]
        public int pieForagers = 5;

        [Name("                  - Breyerhouse Pie")]
        [Description("Set the required cooking skill level for the Breyerhouse Pie recipe.")]
        [Slider(1, 5)]
        public int pieMeat = 5;

        [Name("                  - Stalker's Pie")]
        [Description("Set the required cooking skill level for the Stalker's Pie recipe.")]
        [Slider(1, 5)]
        public int piePredator = 5;

        
        
        //
        [Name("Level 4 Cooking Recipes")]
        [Description("Show or hide level 4 cooking recipes")]
        [Choice("+", "-")]
        public bool recipe4 = false;

        [Name("                  - Lily's Pancakes")]
        [Description("Set the required cooking skill level for the Lily's Pancakes recipe.")]
        [Slider(1, 5)]
        public int pancakePeach = 4;

        [Name("                  - Camber Flight Porridge")]
        [Description("Set the required cooking skill level for the Camber Flight Porridge recipe.")]
        [Slider(1, 5)]
        public int porridgeFruit = 4;

        [Name("                  - Porter's Soup")]
        [Description("Set the required cooking skill level for the Porter's Soup recipe.")]
        [Slider(1, 5)]
        public int soupPtarmigan = 4;

        [Name("                  - Ranger Stew")]
        [Description("Set the required cooking skill level for the Ranger Stew recipe.")]
        [Slider(1, 5)]
        public int stewMeat = 4;

        [Name("                  - Thomson Family Stew")]
        [Description("Set the required cooking skill level for the Thomson Family Stew recipe.")]
        [Slider(1, 5)]
        public int stewVegetables = 4;
        
        
        
        //
        [Name("Level 3 Cooking Recipes")]
        [Description("Show or hide level 3 cooking recipes")]
        [Choice("+", "-")]
        public bool recipe3 = false;

        [Name("                  - Peach Pie")]
        [Description("Set the required cooking skill level for the Peach Pie recipe.")]
        [Slider(1, 5)]
        public int piePeach = 3;

        [Name("                  - Ptarmigan Pie")]
        [Description("Set the required cooking skill level for the Ptarmigan Pie recipe.")]
        [Slider(1, 5)]
        public int piePtarmigan = 3;

        [Name("                  - Rabbit Pie")]
        [Description("Set the required cooking skill level for the Rabbit Pie recipe.")]
        [Slider(1, 5)]
        public int pieRabbit = 3;

        [Name("                  - RoseHip Pie")]
        [Description("Set the required cooking skill level for the RoseHip Pie recipe.")]
        [Slider(1, 5)]
        public int pieRoseHip = 3;

        [Name("                  - Venison Pie")]
        [Description("Set the required cooking skill level for the Venison Pie recipe.")]
        [Slider(1, 5)]
        public int pieVenison = 3;
        
        
        
        //
        [Name("Level 2 Cooking Recipes")]
        [Description("Show or hide level 2 cooking recipes")]
        [Choice("+", "-")]
        public bool recipe2 = false;

        [Name("                  - Bannock")]
        [Description("Set the required cooking skill level for the Bannock recipe.")]
        [Slider(1, 5)]
        public int bannock = 2;

        [Name("                  - Acorn Bannock")]
        [Description("Set the required cooking skill level for the Acorn Bannock recipe.")]
        [Slider(1, 5)]
        public int bannockAcorn = 2;

        [Name("                  - Pancake")]
        [Description("Set the required cooking skill level for the Pancake recipe.")]
        [Slider(1, 5)]
        public int pancake = 2;

        [Name("                  - Acorn Pancake")]
        [Description("Set the required cooking skill level for the Acorn Pancake recipe.")]
        [Slider(1, 5)]
        public int pancakeAcorn = 2;

        //
        [Name("Level 1 Cooking Recipes")]
        [Description("Show or hide level 1 cooking recipes")]
        [Choice("+", "-")]
        public bool recipe1 = false;

        [Name("                  - Broth")]
        [Description("Set the required cooking skill level for the Broth recipe.")]
        [Slider(1, 5)]
        public int broth = 1;

        [Name("                  - Cooking Oil")]
        [Description("Set the required cooking skill level for the Cooking Oil recipe.")]
        [Slider(1, 5)]
        public int cookingOil = 1;

        [Name("                  - Porridge")]
        [Description("Set the required cooking skill level for the Porridge recipe.")]
        [Slider(1, 5)]
        public int porridge = 1;

        [Name("                  - Vagabond Soup")]
        [Description("Set the required cooking skill level for the Vagabond Soup recipe.")]
        [Slider(1, 5)]
        public int soupRabbit = 1;

        [Name("                  - Ptarmigan Stew")]
        [Description("Set the required cooking skill level for the Ptarmigan Stew recipe.")]
        [Slider(1, 5)]
        public int stewPtarmigan = 1;

        [Name("                  - Rabbit Stew")]
        [Description("Set the required cooking skill level for the Rabbit Stew recipe.")]
        [Slider(1, 5)]
        public int stewRabbit = 1;

        [Name("                  - Trout Stew")]
        [Description("Set the required cooking skill level for the Trout Stew recipe.")]
        [Slider(1, 5)]
        public int stewTrout = 1;

        [Name("                  - Venison Stew")]
        [Description("Set the required cooking skill level for the Venison Stew recipe.")]
        [Slider(1, 5)]
        public int stewVenison = 1;

        [Name("                  - Last Resort Soup")]
        [Description("Set the required cooking skill level for the Last Resort Soup recipe.")]
        [Slider(1, 5)]
        public int sweetPotato = 1;

        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
        {
            if (field.Name == nameof(recipe5) ||
                field.Name == nameof(barPemmican) ||
                field.Name == nameof(fishcakes) ||
                field.Name == nameof(pieFishermans) ||
                field.Name == nameof(pieForagers) ||
                field.Name == nameof(pieMeat) ||
                field.Name == nameof(piePredator) ||

                field.Name == nameof(recipe4) ||
                field.Name == nameof(pancakePeach) ||
                field.Name == nameof(porridgeFruit) ||
                field.Name == nameof(soupPtarmigan) ||
                field.Name == nameof(stewMeat) ||
                field.Name == nameof(stewVegetables) ||

                field.Name == nameof(recipe3) ||
                field.Name == nameof(piePeach) ||
                field.Name == nameof(piePtarmigan) ||
                field.Name == nameof(pieRabbit) ||
                field.Name == nameof(pieRoseHip) ||
                field.Name == nameof(pieVenison) ||

                field.Name == nameof(recipe2) ||
                field.Name == nameof(bannock) ||
                field.Name == nameof(bannockAcorn) ||
                field.Name == nameof(pancake) ||
                field.Name == nameof(pancakeAcorn) ||

                field.Name == nameof(recipe1) ||
                field.Name == nameof(broth) ||
                field.Name == nameof(cookingOil) ||
                field.Name == nameof(porridge) ||
                field.Name == nameof(soupRabbit) ||
                field.Name == nameof(stewPtarmigan) ||
                field.Name == nameof(stewRabbit) ||
                field.Name == nameof(stewTrout) ||
                field.Name == nameof(stewVenison) ||
                field.Name == nameof(sweetPotato))
            {
                RefreshGUI();
            }
        }

        internal void RefreshGUI()
        {   
            // Level 5 recipes
            SetFieldVisible(nameof(barPemmican), recipe5);
            SetFieldVisible(nameof(fishcakes), recipe5);
            SetFieldVisible(nameof(pieFishermans), recipe5);
            SetFieldVisible(nameof(pieForagers), recipe5);
            SetFieldVisible(nameof(pieMeat), recipe5);
            SetFieldVisible(nameof(piePredator), recipe5);

            // Level 4 recipes
            SetFieldVisible(nameof(pancakePeach), recipe4);
            SetFieldVisible(nameof(porridgeFruit), recipe4);
            SetFieldVisible(nameof(soupPtarmigan), recipe4);
            SetFieldVisible(nameof(stewMeat), recipe4);
            SetFieldVisible(nameof(stewVegetables), recipe4);

            // Level 3 recipes
            SetFieldVisible(nameof(piePeach), recipe3);
            SetFieldVisible(nameof(piePtarmigan), recipe3);
            SetFieldVisible(nameof(pieRabbit), recipe3);
            SetFieldVisible(nameof(pieRoseHip), recipe3);
            SetFieldVisible(nameof(pieVenison), recipe3);

            // Level 2 recipes
            SetFieldVisible(nameof(bannock), recipe2);
            SetFieldVisible(nameof(bannockAcorn), recipe2);
            SetFieldVisible(nameof(pancake), recipe2);
            SetFieldVisible(nameof(pancakeAcorn), recipe2);

            // Level 1 recipes
            SetFieldVisible(nameof(broth), recipe1);
            SetFieldVisible(nameof(cookingOil), recipe1);
            SetFieldVisible(nameof(porridge), recipe1);
            SetFieldVisible(nameof(soupRabbit), recipe1);
            SetFieldVisible(nameof(stewPtarmigan), recipe1);
            SetFieldVisible(nameof(stewRabbit), recipe1);
            SetFieldVisible(nameof(stewTrout), recipe1);
            SetFieldVisible(nameof(stewVenison), recipe1);
            SetFieldVisible(nameof(sweetPotato), recipe1);
        }

    }



    // Singleton to manage settings
    public static class Settings
    {
        public static RecipeSkillSettings settings;

        public static void OnLoad()
        {
            settings = new RecipeSkillSettings();
            settings.AddToModSettings("RecipeRequirements");
            settings.RefreshGUI();
        }
    }
}
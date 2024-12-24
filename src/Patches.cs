using Il2CppTLD.Cooking;
using HarmonyLib;
using Il2Cpp;

namespace RecipeRequirements
{
    [HarmonyPatch(typeof(RecipeData), nameof(RecipeData.CanBeMadeWithPot))]
    public static class RecipeDataAdjustment
    {
        [HarmonyPostfix]
        public static void Postfix(RecipeData __instance)
        {
            if (GameManager.m_IsPaused || GameManager.s_IsGameplaySuspended)
            {
                return;
            }

            if (__instance == null || string.IsNullOrEmpty(__instance.name))
                return;

            switch (__instance.name)
            {
                // Level 5 recipes
                case "RECIPE_BarPemmican":
                    __instance.m_RequiredSkillLevel = Settings.settings.barPemmican;
                    break;
                case "RECIPE_Fishcakes":
                    __instance.m_RequiredSkillLevel = Settings.settings.fishcakes;
                    break;
                case "RECIPE_PieFishermans":
                    __instance.m_RequiredSkillLevel = Settings.settings.pieFishermans;
                    break;
                case "RECIPE_PieForagers":
                    __instance.m_RequiredSkillLevel = Settings.settings.pieForagers;
                    break;
                case "RECIPE_PieMeat":
                    __instance.m_RequiredSkillLevel = Settings.settings.pieMeat;
                    break;
                case "RECIPE_PiePredator":
                    __instance.m_RequiredSkillLevel = Settings.settings.piePredator;
                    break;
                    
                    
                    // Level 4 recipes
                case "RECIPE_PancakePeach":
                    __instance.m_RequiredSkillLevel = Settings.settings.pancakePeach;
                    break;
                case "RECIPE_PorridgeFruit":
                    __instance.m_RequiredSkillLevel = Settings.settings.porridgeFruit;
                    break;
                case "RECIPE_SoupPtarmigan":
                    __instance.m_RequiredSkillLevel = Settings.settings.soupPtarmigan;
                    break;
                case "RECIPE_StewMeat":
                    __instance.m_RequiredSkillLevel = Settings.settings.stewMeat;
                    break;
                case "RECIPE_StewVegetables":
                    __instance.m_RequiredSkillLevel = Settings.settings.stewVegetables;
                    break;
                    
                    
                    // Level 3 recipes
                case "RECIPE_PiePeach":
                    __instance.m_RequiredSkillLevel = Settings.settings.piePeach;
                    break;
                case "RECIPE_PiePtarmigan":
                    __instance.m_RequiredSkillLevel = Settings.settings.piePtarmigan;
                    break;
                case "RECIPE_PieRabbit":
                    __instance.m_RequiredSkillLevel = Settings.settings.pieRabbit;
                    break;
                case "RECIPE_PieRoseHip":
                    __instance.m_RequiredSkillLevel = Settings.settings.pieRoseHip;
                    break;
                case "RECIPE_PieVenison":
                    __instance.m_RequiredSkillLevel = Settings.settings.pieVenison;
                    break;
                    
                    
                    // Level 2 recipes
                case "RECIPE_Bannock":
                    __instance.m_RequiredSkillLevel = Settings.settings.bannock;
                    break;
                case "RECIPE_BannockAcorn":
                    __instance.m_RequiredSkillLevel = Settings.settings.bannockAcorn;
                    break;
                case "RECIPE_Pancake":
                    __instance.m_RequiredSkillLevel = Settings.settings.pancake;
                    break;
                case "RECIPE_PancakeAcorn":
                    __instance.m_RequiredSkillLevel = Settings.settings.pancakeAcorn;
                    break;


                // Level 1 recipes
                case "RECIPE_Broth":
                    __instance.m_RequiredSkillLevel = Settings.settings.broth;
                    break;
                case "RECIPE_CookingOil":
                    __instance.m_RequiredSkillLevel = Settings.settings.cookingOil;
                    break;
                case "RECIPE_Porridge":
                    __instance.m_RequiredSkillLevel = Settings.settings.porridge;
                    break;
                case "RECIPE_SoupRabbit":
                    __instance.m_RequiredSkillLevel = Settings.settings.soupRabbit;
                    break;
                case "RECIPE_StewPtarmigan":
                    __instance.m_RequiredSkillLevel = Settings.settings.stewPtarmigan;
                    break;
                case "RECIPE_StewRabbit":
                    __instance.m_RequiredSkillLevel = Settings.settings.stewRabbit;
                    break;
                case "RECIPE_StewTrout":
                    __instance.m_RequiredSkillLevel = Settings.settings.stewTrout;
                    break;
                case "RECIPE_StewVenison":
                    __instance.m_RequiredSkillLevel = Settings.settings.stewVenison;
                    break;
                case "RECIPE_SweetPotato":
                    __instance.m_RequiredSkillLevel = Settings.settings.sweetPotato;
                    break;

                default:
                    break;
            }
        }
    }
}

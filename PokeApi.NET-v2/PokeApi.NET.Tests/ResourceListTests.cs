using System.Threading.Tasks;
using Xunit;

namespace PokeAPI.Tests
{
    public class ResourceListTests
    {
        /// <summary>
        /// Method for running a resource list test.
        /// </summary>
        /// <param name="expectedCount">The expected resource count.</param>
        private static async Task GetsResourceList<T>(int expectedCount) where T : NamedApiObject
        {
            var t = await DataFetcher.GetResourceList<NamedApiResource<T>, T>();
            Assert.NotNull(t);
            Assert.Equal(expectedCount, t.Count);

            var enumerator = t.GetEnumerator();
            var enumCount = 0;

            while (enumerator.MoveNext())
            {
                enumCount++;
            }

            Assert.Equal(expectedCount, enumCount);

            enumerator.Dispose();
        }

        /// <summary>
        /// Verify that <see cref="Ability"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsAbilityResourceList()
        {
            await GetsResourceList<Ability>(293);
        }

        /// <summary>
        /// Verify that <see cref="BerryFirmness"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsBerryFirmnessResourceList()
        {
            await GetsResourceList<BerryFirmness>(5);
        }

        /// <summary>
        /// Verify that <see cref="BerryFlavor"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsBerryFlavorResourceList()
        {
            await GetsResourceList<BerryFlavor>(5);
        }

        /// <summary>
        /// Verify that <see cref="Berry"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsBerryResourceList()
        {
            await GetsResourceList<Berry>(64);
        }

        /// <summary>
        /// Verify that <see cref="ContestType"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsContestTypeResourceList()
        {
            await GetsResourceList<ContestType>(5);
        }

        /// <summary>
        /// Verify that <see cref="EggGroup"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsEggGroupResourceList()
        {
            await GetsResourceList<EggGroup>(15);
        }

        /// <summary>
        /// Verify that <see cref="EncounterCondition"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsEncounterConditionResourceList()
        {
            await GetsResourceList<EncounterCondition>(6);
        }

        /// <summary>
        /// Verify that <see cref="EncounterConditionValue"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsEncounterConditionValueResourceList()
        {
            await GetsResourceList<EncounterConditionValue>(20);
        }

        /// <summary>
        /// Verify that <see cref="EncounterMethod"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsEncounterMethodResourceList()
        {
            await GetsResourceList<EncounterMethod>(17);
        }

        /// <summary>
        /// Verify that <see cref="EvolutionTrigger"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsEvolutionTriggerResourceList()
        {
            await GetsResourceList<EvolutionTrigger>(4);
        }

        /// <summary>
        /// Verify that <see cref="GameVersion"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsGameVersionResourceList()
        {
            await GetsResourceList<GameVersion>(30);
        }

        /// <summary>
        /// Verify that <see cref="Gender"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsGenderResourceList()
        {
            await GetsResourceList<Gender>(3);
        }

        /// <summary>
        /// Verify that <see cref="Generation"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsGenerationResourceList()
        {
            await GetsResourceList<Generation>(7);
        }

        /// <summary>
        /// Verify that <see cref="GrowthRate"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsGrowthRateResourceList()
        {
            await GetsResourceList<GrowthRate>(6);
        }

        /// <summary>
        /// Verify that <see cref="ItemAttribute"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsItemAttributeResourceList()
        {
            await GetsResourceList<ItemAttribute>(8);
        }

        /// <summary>
        /// Verify that <see cref="ItemCategory"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsItemCategoryResourceList()
        {
            await GetsResourceList<ItemCategory>(45);
        }

        /// <summary>
        /// Verify that <see cref="ItemFlingEffect"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsItemFlingEffectResourceList()
        {
            await GetsResourceList<ItemFlingEffect>(7);
        }

        /// <summary>
        /// Verify that <see cref="ItemPocket"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsItemPocketResourceList()
        {
            await GetsResourceList<ItemPocket>(8);
        }

        /// <summary>
        /// Verify that <see cref="Item"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsItemResourceList()
        {
            await GetsResourceList<Item>(954);
        }

        /// <summary>
        /// Verify that <see cref="Language"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsLanguageResourceList()
        {
            await GetsResourceList<Language>(12);
        }

        /// <summary>
        /// Verify that <see cref="LocationArea"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsLocationAreaResourceList()
        {
            await GetsResourceList<LocationArea>(651);
        }

        /// <summary>
        /// Verify that <see cref="Location"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsLocationResourceList()
        {
            await GetsResourceList<Location>(781);
        }

        /// <summary>
        /// Verify that <see cref="MoveAilment"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsMoveAilmentResourceList()
        {
            await GetsResourceList<MoveAilment>(21);
        }

        /// <summary>
        /// Verify that <see cref="MoveBattleStyle"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsMoveBattleStyleResourceList()
        {
            await GetsResourceList<MoveBattleStyle>(3);
        }

        /// <summary>
        /// Verify that <see cref="MoveCategory"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsMoveCategoryResourceList()
        {
            await GetsResourceList<MoveCategory>(14);
        }

        /// <summary>
        /// Verify that <see cref="MoveDamageClass"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsMoveDamageClassResourceList()
        {
            await GetsResourceList<MoveDamageClass>(3);
        }

        /// <summary>
        /// Verify that <see cref="MoveLearnMethod"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsMoveLearnMethodResourceList()
        {
            await GetsResourceList<MoveLearnMethod>(10);
        }

        /// <summary>
        /// Verify that <see cref="Move"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsMoveResourceList()
        {
            await GetsResourceList<Move>(746);
        }

        /// <summary>
        /// Verify that <see cref="MoveTarget"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsMoveTargetResourceList()
        {
            await GetsResourceList<MoveTarget>(14);
        }

        /// <summary>
        /// Verify that <see cref="Nature"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsNatureResourceList()
        {
            await GetsResourceList<Nature>(25);
        }

        /// <summary>
        /// Verify that <see cref="PalParkArea"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsPalParkAreaResourceList()
        {
            await GetsResourceList<PalParkArea>(5);
        }

        /// <summary>
        /// Verify that <see cref="PokeathlonStat"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsPokeathlonStatResourceList()
        {
            await GetsResourceList<PokeathlonStat>(5);
        }

        /// <summary>
        /// Verify that <see cref="Pokedex"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsPokedexResourceList()
        {
            await GetsResourceList<Pokedex>(14);
        }

        /// <summary>
        /// Verify that <see cref="PokemonColour"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsPokemonColourResourceList()
        {
            await GetsResourceList<PokemonColour>(10);
        }

        /// <summary>
        /// Verify that <see cref="PokemonForm"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsPokemonFormResourceList()
        {
            await GetsResourceList<PokemonForm>(1123);
        }

        /// <summary>
        /// Verify that <see cref="PokemonHabitat"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsPokemonHabitatResourceList()
        {
            await GetsResourceList<PokemonHabitat>(9);
        }

        /// <summary>
        /// Verify that <see cref="Pokemon"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsPokemonResourceList()
        {
            await GetsResourceList<Pokemon>(964);
        }

        /// <summary>
        /// Verify that <see cref="PokemonShape"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsPokemonShapeResourceList()
        {
            await GetsResourceList<PokemonShape>(14);
        }

        /// <summary>
        /// Verify that <see cref="PokemonSpecies"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsPokemonSpeciesResourceList()
        {
            await GetsResourceList<PokemonSpecies>(807);
        }

        /// <summary>
        /// Verify that <see cref="PokemonType"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsPokemonTypeResourceList()
        {
            await GetsResourceList<PokemonType>(20);
        }

        /// <summary>
        /// Verify that <see cref="Region"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsRegionResourceList()
        {
            await GetsResourceList<Region>(7);
        }

        /// <summary>
        /// Verify that <see cref="Stat"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsStatResourceList()
        {
            await GetsResourceList<Stat>(8);
        }

        /// <summary>
        /// Verify that <see cref="VersionGroup"/> has its resource list fetched correctly.
        /// </summary>
        [Fact]
        public async void GetsVersionGroupResourceList()
        {
            await GetsResourceList<VersionGroup>(18);
        }
    }
}
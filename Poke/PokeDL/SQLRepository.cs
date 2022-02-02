using PokeModel;

namespace PokeDL
{
    public class SQLRepository : IRepository
    {
        public Pokemon AddPokemon(Pokemon p_poke)
        {
            // @ before the stringf will ignore special characters like \n
            // This is where you specify the sql statement required to do whatever operation you need based on the method
            string sqlQuery = @"insert into Pokemon
                                    values (@pokeName, @pokeLevel, @pokeAttack, @pokeDefense, @pokeHealth)";
            using ()
            {
        
            }
        }

        public List<Pokemon> GetAllPokemon()
        {

        }
    }
}
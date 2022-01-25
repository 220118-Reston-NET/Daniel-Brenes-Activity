namespace PokeBL
{
    /// <summary>
    /// Business layer is responsible for further validation or processing of data obtained from either the database or the user
    /// What kind of processing? That all depends on the type of functionality you will be doing
    /// </summary>
    public interface IPokemonBL
    {
        /// <summary>
        /// Will add a pokemon data to the database
        /// Initital addition of a pokemon will give it some sort of randomize starts
        /// Can only have the total of 4 pokemons in the database
        /// </summary>
        /// <param name = "p_poke" ></param>
        /// <returns></returns>
        Pokemon AddPokemon(Pokemon p_poke);
    }

}
using PokeModel;
namespace PokeDL
{
    /// <summary>
    /// Data Layer project is responsible for interacting with our database and doing CRUD operations
    /// C Create, R Read, U Update, D Delete
    /// It must not have logical operation that will also manipulate the data it is grabbing
    /// Just think of Data layer as the delivery man of your uber eats. You definitely don't want your delivery man to touch 
    /// the food he is delivering. 
    /// </summary>

    public interface IRepository
    {
        /// <summary>
        /// Add a pokemon to the database
        /// </summary>
        /// <param name = "p_poke"> This the pokemon object we are adding to the database <>
        Pokemon AddPokemon(Pokemon p_poke);


    }
}
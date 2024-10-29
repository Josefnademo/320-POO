
namespace BoatNamespace
{
    public interface IContainer
    {
        // Propriétés du container
        int Id { get; }
        float Weight { get; }
        bool IsRefrigerated { get; }
        List<string> Merchandise { get; }
        string Color { get; }

        // Méthodes pour le container
        void ViewContent();  // Voir le contenu du container
        void AddMerchandise(string item);  // Ajouter un élément dans le container
    }
}
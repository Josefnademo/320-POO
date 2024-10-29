using System;
using System.Collections.Generic;



namespace BoatNamespace
{
    public interface IBoat
    {
        // Propriétés du bateau
        string Name { get; }
        float MaxCargoWeight { get; }
        int MaxSpeed { get; }

        // Méthodes pour le bateau
        void Start();  // Démarrer le bateau
        bool LoadContainer(IContainer container);  // Charger un container
        bool UnloadContainer(IContainer container);  // Décharger un container
    }
}

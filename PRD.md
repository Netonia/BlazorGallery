# Product Requirements Document (PRD)  
## Mini-galerie photo statique (Blazor WASM)

### 1. Objectif
Créer une galerie photo simple, hébergée sur GitHub Pages, utilisant Blazor WebAssembly.  
Les images sont chargées statiquement depuis le dossier `wwwroot/images`.  
Aucune API externe, aucune base de données.

---

### 2. Utilisateurs cibles
- Photographes amateurs voulant publier un portfolio simple.  
- Toute personne voulant partager une galerie statique.  

---

### 3. Fonctionnalités principales
1. **Affichage des images**
   - Chargement automatique des fichiers du dossier `wwwroot/images`.
   - Miniatures affichées dans une grille responsive (Bootstrap).  

2. **Visionneuse (Lightbox)**
   - Clic sur une miniature → affichage en plein écran.  
   - Navigation entre photos avec boutons "Précédent/Suivant".  

3. **Navigation / Filtrage**
   - Possibilité de trier par nom de fichier ou date (si métadonnées fournies en JSON).  

4. **Mode responsive**
   - Adaptation mobile/tablette/desktop.  

---

### 4. Fonctionnalités secondaires (optionnelles)
- **Mode sombre/clair** (toggle).  
- **Téléchargement direct** de l’image en haute résolution.  
- **Pagination** si plus de 50 images.  

---

### 5. Contraintes techniques
- Framework : **Blazor WebAssembly** (C#).  
- UI : **Bootstrap 5**.  
- Hébergement : **GitHub Pages**.  
- Images placées dans `wwwroot/images/`.  
- Optionnel : `wwwroot/images.json` pour stocker métadonnées (titre, tags, date).  

---

### 6. Performance
- Mise en cache navigateur via GitHub Pages.  
- Lazy loading des images pour réduire temps de chargement.  

---

### 7. Architecture
- **Components** :
  - `Gallery.razor` : affichage grille des miniatures.  
  - `Lightbox.razor` : visionneuse plein écran.  
  - `Navbar.razor` : navigation, recherche, mode sombre.  

- **Services** :
  - `ImageService.cs` : récupération de la liste des images depuis `/images.json` ou indexation statique. 

---

### 8. Flux utilisateur
1. L’utilisateur arrive sur la page d’accueil.  
2. La grille affiche toutes les photos disponibles.  
3. Un clic ouvre la lightbox.  
4. L’utilisateur peut défiler, fermer ou télécharger. 

---

### 9. Roadmap
- **MVP (Version 1)** : affichage grille + lightbox basique.  
- **V2** : favoris + mode sombre.  
- **V3** : filtres, recherche, pagination.  

---

### 10. Critères de réussite
- Déploiement fonctionnel sur GitHub Pages.  
- Affichage correct des images depuis `wwwroot/images`.  
- Navigation fluide sur mobile et desktop.  

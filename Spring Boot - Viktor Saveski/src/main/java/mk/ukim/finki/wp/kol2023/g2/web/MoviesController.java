package mk.ukim.finki.wp.kol2023.g2.web;

import mk.ukim.finki.wp.kol2023.g2.model.Genre;
import mk.ukim.finki.wp.kol2023.g2.model.Movie;
import mk.ukim.finki.wp.kol2023.g2.service.DirectorService;
import mk.ukim.finki.wp.kol2023.g2.service.MovieService;
import org.springframework.format.annotation.DateTimeFormat;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;

import java.util.List;

@Controller
public class MoviesController {

    private final MovieService movieService;
    private final DirectorService directorService;

    public MoviesController(MovieService movieService, DirectorService directorService) {
        this.movieService = movieService;
        this.directorService = directorService;
    }

    /**
     * This method should use the "list.html" template to display all movies.
     * The method should be mapped on paths '/' and '/movies'.
     * The arguments that this method takes are optional and can be 'null'.
     * In the case when the arguments are not passed (both are 'null') all movies should be displayed.
     * If one, or both of the arguments are not 'null', the movies that are the result of the call
     * to the method 'listMoviesWithRatingGreaterThenAndGenre' from the MovieService should be displayed.
     *
     * @param rating
     * @param genre
     * @return The view "list.html".
     */
    @GetMapping({"/","/beaches"})
    public String showMovies(@RequestParam(required = false) Double rating, @RequestParam(required = false) Genre genre, Model model) {
        List<Movie> movieList;
        if (rating == null && genre == null) {
         movieList =   this.movieService.listAllMovies();
        } else {
            movieList =this.movieService.listMoviesWithRatingLessThenAndGenre(rating, genre);
        }
        model.addAttribute("movieList",movieList);
        return "list";
    }

    /**
     * This method should display the "form.html" template.
     * The method should be mapped on path '/movies/add'.
     *
     * @return The view "form.html".
     */
    @GetMapping("/beaches/add")
    public String showAdd(Model model) {
        model.addAttribute("genreList",Genre.values());
        model.addAttribute("directorList", directorService.listAll());
        return "form";
    }

    /**
     * This method should display the "form.html" template.
     * However, in this case all 'input' elements should be filled with the appropriate value for the movie that is updated.
     * The method should be mapped on path '/movies/[id]/edit'.
     *
     * @return The view "form.html".
     */
    @GetMapping("/beaches/{id}/edit")
    public String showEdit(@PathVariable Long id,Model model) {
        this.movieService.findById(id);
        model.addAttribute("movie",movieService.findById(id));
        model.addAttribute("genreList",Genre.values());
        model.addAttribute("directorList", directorService.listAll());
        return "form";
    }

    /**
     * This method should create a movie given the arguments it takes.
     * The method should be mapped on path '/movies'.
     * After the movie is created, all movies should be displayed.
     *
     * @return The view "list.html".
     */
    @PostMapping("/beaches")
    public String create(@RequestParam(required = false) String name,
                         @RequestParam(required = false) String description,
                         @RequestParam(required = false) Double rating,
                         @RequestParam(required = false) Genre genre,
                         @RequestParam(required = false) Long director) {
        this.movieService.create(name, description, rating, genre, director);
        return "redirect:/beaches";
    }

    /**
     * This method should update a movie given the arguments it takes.
     * The method should be mapped on path '/movies/[id]'.
     * After the movie is updated, all movies should be displayed.
     *
     * @return The view "list.html".
     */
    @PostMapping("/beaches/{id}")
    public String update(@PathVariable Long id,
                         @RequestParam(required = false) String name,
                         @RequestParam(required = false) String description,
                         @RequestParam(required = false) Double rating,
                         @RequestParam(required = false) Genre genre,
                         @RequestParam(required = false)  Long director) {
        this.movieService.update(id, name, description, rating, genre, director);
        return "redirect:/beaches";
    }

    /**
     * This method should delete the movie that has the appropriate identifier.
     * The method should be mapped on path '/movies/[id]/delete'.
     * After the movie is deleted, all movies should be displayed.
     *
     * @return The view "list.html".
     */
    @PostMapping("/beaches/{id}/delete")
    public String delete(@PathVariable Long id) {
        this.movieService.delete(id);
        return "redirect:/beaches";
    }

    /**
     * This method should increase the number of votes of the appropriate movie by 1.
     * The method should be mapped on path '/movies/[id]/vote'.
     * After the operation, all movies should be displayed.
     *
     * @return The view "list.html".
     */
    @PostMapping("/beaches/{id}/vote")
    public String vote(@PathVariable Long id) {
        this.movieService.vote(id);
        return "redirect:/beaches";
    }
}

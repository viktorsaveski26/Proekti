package mk.ukim.finki.wp.kol2023.g2.config;

import mk.ukim.finki.wp.kol2023.g2.model.Genre;
import mk.ukim.finki.wp.kol2023.g2.service.DirectorService;
import mk.ukim.finki.wp.kol2023.g2.service.MovieService;
import org.springframework.stereotype.Component;

import javax.annotation.PostConstruct;

@Component
public class DataInitializer {

    private final DirectorService directorService;

    private final MovieService movieService;

    private final String[] beachNames = {
            "Канео", "Потпеш", "Куба", "Кадмо", "Парк", "Инекс", "Горица3", "Гранит", "Метропол", "Акапулко"
    };
    private final String[] minutes = {
            "3-4min","4-5min","5-6min","6min","7min","8min","9min","10-11min","12-13min","14min"
    };
    private final String[] ratings = {
        "10.0" ,"8.60","8.40","7.00","8.85","8.65","6.95","6.50","7.70","8.00"
    };
    private final String[] interesting = {
      "everyone","older people","20-32 yo","everyone","20-32 yo","older people","15-20 yo","everyone","everyone","everyone"
    };

    public DataInitializer(DirectorService directorService, MovieService movieService) {
        this.directorService = directorService;
        this.movieService = movieService;
    }

    private Genre randomizePosition(int i) {
        if(i % 3 == 0)
            return Genre.Everyone;
        else if(i % 3 == 1) return Genre.TwentyFive;
        return Genre.OlderPeople;
    }

    @PostConstruct
    public void initData() {
        for (int i = 1; i <= 10; i++) {
            this.directorService.create("Beach number: " + i);
        }

        for (int i = 0; i < 10; i++) {
            this.movieService.create(beachNames[i], minutes[i], Double.valueOf(ratings[i]), this.randomizePosition(i+1), this.directorService.listAll().get(i % 10).getId());
        }
    }

}


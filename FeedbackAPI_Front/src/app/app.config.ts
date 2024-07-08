import { ApplicationConfig, provideZoneChangeDetection } from '@angular/core';
import { provideClientHydration } from '@angular/platform-browser';
import { provideHttpClient} from '@angular/common/http';
import { AppComponent } from './app.component';
import { DatasendService } from './services/datasend.service';

export const appConfig: ApplicationConfig = {
  providers: [provideZoneChangeDetection({ eventCoalescing: true }), provideClientHydration(), provideHttpClient()],
};

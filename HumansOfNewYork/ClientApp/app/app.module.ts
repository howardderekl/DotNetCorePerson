import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { UniversalModule } from 'angular2-universal';
import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { HumansComponent } from './components/humans/humans.component';
import { HumanDelayComponent } from './components/human-delay/humandelay.component';

@NgModule({
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        HumansComponent,
        HumanDelayComponent
    ],
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'humans', component: HumansComponent },
            { path: 'human-delay', component: HumanDelayComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModule {
}

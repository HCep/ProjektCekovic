import { NavComponent } from './nav/nav.component';
import { ServicesjobComponent } from './servicesjob/servicesjob.component';
import { PortfolioComponent } from './portfolio/portfolio.component';
import { BlogComponent } from './blog/blog.component';
import { Routes,  RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';


export const appRoutes: Routes = [
  {path: 'nav', component: NavComponent},
  {path: '', component: HomeComponent},
  {path: 'blog', component: BlogComponent},
  {path: 'portfolio', component: PortfolioComponent},
  {path: 'servicesjob', component: ServicesjobComponent},
  {path: '**', redirectTo: '', pathMatch: 'full'},
];

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CompaniesComponent } from '../companies/companies.component';
import { ReviewsComponent } from '../reviews/reviews.component';

const routes: Routes = [
  {
    path: '',
    component: CompaniesComponent,
  },
  {
    path: 'reviews',
    component: ReviewsComponent,
  },
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule
  ],
  declarations: []
})
export class AppRoutingModule { }

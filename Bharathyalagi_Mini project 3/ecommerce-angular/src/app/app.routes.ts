import { Routes } from '@angular/router';

import { OrdersComponent } from './pages/orders/orders';
import { HomeComponent } from './pages/home/home';
import { CartComponent } from './components/cart/cart';
import { AdminComponent } from './pages/admin/admin';
import { LoginComponent } from './pages/login/login';
import { ProductListComponent } from './components/product-list/product-list';
import { RegisterComponent } from './pages/register/register';
import { authGuard } from './guards/auth-guard';

export const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'products', component: ProductListComponent, runGuardsAndResolvers: 'always' },
  { path: 'cart', component: CartComponent },
  { path: 'admin', component: AdminComponent, canActivate: [authGuard] },
  { path: 'login', component: LoginComponent },
  { path: 'orders', component: OrdersComponent },
  { path: 'register', component: RegisterComponent }
];
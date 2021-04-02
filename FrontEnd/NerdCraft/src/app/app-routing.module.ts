import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddressComponent } from './address/address.component';
import { CardComponent } from './card/card.component';
import { CustomerComponent } from './customer/customer.component';
import { DiscountComponent } from './discount/discount.component';
import { EmployeeComponent } from './employee/employee.component';
import { ItemComponent } from './item/item.component';
import { OrderComponent } from './order/order.component';
import { OrderedItemComponent } from './ordered-item/ordered-item.component';
import { PaymentComponent } from './payment/payment.component';
import { PersonComponent } from './person/person.component';
import { ReturnmentComponent } from './returnment/returnment.component';
import { ReviewsComponent } from './reviews/reviews.component';
import { SellerComponent } from './seller/seller.component';
import { ShipmentComponent } from './shipment/shipment.component';
import { ShoppingCartComponent } from './shopping-cart/shopping-cart.component';
import { WishlistComponent } from './wishlist/wishlist.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'list',
    pathMatch: 'full'
  },
  {
    path: 'SellerList',
    
    component: SellerComponent,
  },
  {
    path: 'SellerAdd',
    
    component: SellerComponent,
  },
  {
    path: 'SellerEdit/:id',
    
    component: SellerComponent,
    
  },
  {
    path: 'SellerDetail/:id',
    
    component: SellerComponent,
    
  },
  {
    path: 'storefront',
    component: ItemComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
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
import { SellerComponent } from './seller/seller.component';
import { ShipmentComponent } from './shipment/shipment.component';
import { ShoppingCartComponent } from './shopping-cart/shopping-cart.component';
import { WishlistComponent } from './wishlist/wishlist.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LoginComponent,
    RegisterComponent,
    AddressComponent,
    CardComponent,
    CustomerComponent,
    DiscountComponent,
    EmployeeComponent,
    ItemComponent,
    OrderComponent,
    OrderedItemComponent,
    PaymentComponent,
    PersonComponent,
    ReturnmentComponent,
    SellerComponent,
    ShipmentComponent,
    ShoppingCartComponent,
    WishlistComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

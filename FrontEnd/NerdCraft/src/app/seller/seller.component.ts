import { Component, OnInit } from '@angular/core';
import { Seller } from '../models/seller';
import { SellerService } from '../services/seller.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-seller',
  templateUrl: './seller.component.html',
  styleUrls: ['./seller.component.css']
})
export class SellerComponent implements OnInit {
  //seller service is what is communicating with the back end
  constructor(private sellerService: SellerService, private router: Router) { }
  //allows us to create new instances of seller
  newSeller: Seller = new Seller();
  //empty array to store all new sellers
  sellers: Seller[] = [];

  //CRUD OPERATIONS

  //get sellers -> READ
  getSellers(){
    this.sellerService.getSellers().subscribe(sellers => (this.sellers = sellers));
  }

  //CREATE
  addSeller(){
    this.sellerService.addSeller(this.newSeller).subscribe( result => {
      this.getSellers();
      this.newSeller = new Seller();
    })
  }

  //UPDATE
  editSeller(){
    //call on seller service editSeller function
    this.sellerService
    .editSeller(this.newSeller)
    .subscribe(s => this.router.navigate(['storefront']));
  }

  //DELETE
  deleteSeller(id: number): void {
    this.sellerService.deleteSeller(id).subscribe(s => this.router.navigate(['storefront']));
  }

  ngOnInit(): void {
  }

}

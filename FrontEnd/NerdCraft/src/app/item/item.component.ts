import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Item } from '../models/item';
import { ItemService } from '../services/item.service';

@Component({
  selector: 'app-item',
  templateUrl: './item.component.html',
  styleUrls: ['./item.component.css']
})
export class ItemComponent implements OnInit {
  

  constructor(private itemService: ItemService, private router: Router) {}

  newItem: Item = new Item();

  items: Item[] = [];

  getItems(){
    this.itemService.getItems().subscribe(items => (this.items = items));
  }

  addItem(){
    this.itemService.addItem(this.newItem).subscribe(result => {
      this.getItems();
      this.newItem = new Item();
    })
  }

  editItem(){
    this.itemService
    .editItem(this.newItem)
    .subscribe(i => this.router.navigate(['storefront']));
  }

  deleteItem(ItemID: number): void {
    this.itemService.deleteItem(ItemID).subscribe(i => this.router.navigate(['storefront']));
  }

  ngOnInit(): void {
  }

}

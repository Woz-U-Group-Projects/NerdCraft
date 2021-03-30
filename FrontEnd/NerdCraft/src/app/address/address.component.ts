import { Component, OnInit } from '@angular/core';
import { AddressService } from '../services/address.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-address',
  templateUrl: './address.component.html',
  styleUrls: ['./address.component.css']
})
export class AddressComponent implements OnInit {
  address = [];

  constructor() { }

  ngOnInit(): void {
  }

}

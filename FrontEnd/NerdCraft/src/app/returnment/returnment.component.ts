import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-returnment',
  templateUrl: './returnment.component.html',
  styleUrls: ['./returnment.component.css']
})
export class ReturnmentComponent implements OnInit {
  returnment = [];

  constructor() { }

  ngOnInit(): void {
  }

}

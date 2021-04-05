import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Item } from '../models/item';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ItemService {

  constructor(private http: HttpClient) { }

  apiUrl: string = "http://localhost:4200/items"; //url to connect with backend

  getItems(): Observable<Item[]>{
    return this.http.get<Item[]>(this.apiUrl);
  }

  addItem(item: Item): Observable<Item>{
    return this.http.post<Item>(this.apiUrl, item);
  }

  editItem(item: Item): Observable<Item>{
    return this.http.put<Item>(this.apiUrl + '/' + Item.ItemID, item);
  }

  deleteItem(ItemID: number): Observable<Item>{
    return this.http.delete<Item>(this.apiUrl + '/' + ItemID);
  }

}

import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import {Seller} from "../models/seller";

@Injectable({
  providedIn: 'root'
})
export class SellerService {

  constructor(private http: HttpClient) { }

  apiUrl: string = "http://localhost:4200/sellers";

  getSellers(): Observable<Seller[]>{
    return this.http.get<Seller[]>(this.apiUrl);
  }

  addSeller(seller: Seller): Observable<Seller>{
    return this.http.post<Seller>(this.apiUrl,seller );
  }

  //identifer to choose which seller we are editing
  editSeller(seller: Seller): Observable<Seller>{
    //locate the correct seller by id
    //put request to pass the updated seller to replace outdated seller info
    return this.http.put<Seller>(this.apiUrl + '/' + seller.ID, seller);
  }

  deleteSeller(id: number): Observable<Seller>{
    return this.http.delete<Seller>(this.apiUrl + '/' + id);
  }
  //delete request
}

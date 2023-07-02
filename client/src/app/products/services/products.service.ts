import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IProduct } from '../models/product';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {

  constructor(private http: HttpClient) { }

  getProductsList(
    simulator: string, 
    sortField: string, 
    sortOrder: string): Observable<IProduct[]> {
      // TODO: Include sortField and sortOrder parameters as query params
      //TODO: Put API base url in Environment variable
      const url = `http://localhost:5000/api/products/top/${simulator}`;
      
      return this.http.get<IProduct[]>(url);
  };
}

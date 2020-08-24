import { Injectable } from '@angular/core';
import { ItemDetail } from './Item-detail.model';

@Injectable({
  providedIn: 'root'
})
export class ItemDetailService {
  formData: ItemDetail

  constructor() { }
}

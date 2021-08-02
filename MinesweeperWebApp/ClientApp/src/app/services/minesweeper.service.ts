import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class MinesweeperService {

  constructor(private http: HttpClient) { }

  getPanel(width, height) {

    let params = new HttpParams()
      .set('width', width)
      .set("height", height);

    return this.http.get<Row[]>('/api/panel', { params: params })
      .pipe(map(res => res)); 
  }
}

export interface Row {
  cells: Cell[];
}

export interface Cell {
  location: Location;
  hasBomb: boolean;
}

export interface Location {
  row: number;
  column: number;
}

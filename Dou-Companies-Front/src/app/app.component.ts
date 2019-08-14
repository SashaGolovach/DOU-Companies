import { Component, OnInit, ViewChild } from '@angular/core';
import { MatSort, MatPaginator } from '@angular/material';
import { HttpClient } from '@angular/common/http';
import { ODataDataSource } from 'odata-data-source';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;

  title = 'odata-data-source-demo';

  displayedColumns: string[] = ['Name'];

  dataSource: ODataDataSource;

  constructor(private readonly httpClient: HttpClient) { }

  ngOnInit() {
    const resourcePath = 'odata/comp';
    this.dataSource = new ODataDataSource(this.httpClient, resourcePath);
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
  }
}

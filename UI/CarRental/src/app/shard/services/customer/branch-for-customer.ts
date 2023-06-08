import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BranchForList } from '../../models/branch/branch-for-list';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';

@Injectable()
export class BranchForCustomerService {
  constructor(private httpClient: HttpClient) {}

  private className: string = 'BranchForCustomer/';

  getBranchesByCountry(country: string): Observable<BranchForList[]> {
    const url = `${environment.apiUrl}${this.className}GetBranchesByCountry/${country}`;
    return this.httpClient.get<BranchForList[]>(url);
  }
}

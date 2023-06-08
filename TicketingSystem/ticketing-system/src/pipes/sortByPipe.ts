import { Pipe, PipeTransform } from '@angular/core';

/**
 * Sorts the array by the given field 
 */

@Pipe({name: 'sortBy'})
export class SortByPipe implements PipeTransform {
  transform(array: Array<any>, field: string): Array<any> {
    if (!Array.isArray(array)) {
      return array;
    }

    array.sort((a: any, b: any) => {
      if (a[field] < b[field]) {
        return -1;
      } else if (a[field] > b[field]) {
        return 1;
      } else {
        return 0;
      }
    });

    return array;
  }
}
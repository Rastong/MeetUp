export interface EventList {
  id: number;
  name: string;
  host: string;
  categoryID: number;
  summary: string;
  photo: string;
  dateAndTime: string;
  guestCount: number;
  spotsFilled: boolean;
  //Reference by FK in userFavorites
  favorites: null;
}

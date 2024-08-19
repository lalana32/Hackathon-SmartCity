export interface User {
  email: string;
  token: string;
  firstName: string;
  lastName: string;
  userName: string;
  roles?: string[];

  jmbg: string;
}

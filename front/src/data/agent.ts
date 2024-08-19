import axios, { AxiosResponse } from 'axios';

axios.defaults.baseURL = 'http://localhost:5024/api/';

const responseBody = (response: AxiosResponse) => response.data;

const request = {
  get: (url: string, token?: string) => {
    const headers = token ? { Authorization: `Bearer ${token}` } : {};
    return axios.get(url, { headers }).then(responseBody);
  },
  post: (url: string, body: {}, token?: string) => {
    const headers = token ? { Authorization: `Bearer ${token}` } : {};
    return axios.post(url, body, { headers }).then(responseBody);
  },
  put: (url: string, body: {}, token?: string) => {
    const headers = token ? { Authorization: `Bearer ${token}` } : {};
    return axios.put(url, body, { headers }).then(responseBody);
  },
  delete: (url: string, token?: string) => {
    const headers = token ? { Authorization: `Bearer ${token}` } : {};
    return axios.delete(url, { headers }).then(responseBody);
  },
};

const Auth = {
  login: (values: any, token?: string) =>
    request.post('Auth/login', values, token),
  register: (values: any, token?: string) =>
    request.post('Auth/register', values, token),
  currentUser: (token?: string) => request.get('Auth/currentUser', token),
  updateUser: (userData: any, token?: string) =>
    request.put('Auth/edit', userData, token),
};

const agent = {
  Auth,
};
export default agent;

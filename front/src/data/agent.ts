import axios, { AxiosResponse } from 'axios';
import store from '../store/configureStore';

axios.defaults.baseURL = 'http://localhost:5024/api/';

const responseBody = (response: AxiosResponse) => response.data;
axios.interceptors.request.use((config: any) => {
  const token = store.getState().account.user?.token;
  if (token) config.headers.Authorization = `Bearer ${token}`;
  return config;
});
const request = {
  get: (url: string) => axios.get(url).then(responseBody),
  post: (url: string, body: {}) => axios.post(url, body).then(responseBody),
  put: (url: string, body: {}) => axios.put(url, body).then(responseBody),
  delete: (url: string) => axios.delete(url).then(responseBody),
};

const Auth = {
  login: (values: any) => request.post('Auth/login', values),
  register: (values: any) => request.post('Auth/register', values),
  currentUser: () => request.get('Auth/currentUser'),
};

const agent = {
  Auth,
};
export default agent;

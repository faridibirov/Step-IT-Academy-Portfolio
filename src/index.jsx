import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import { RouterProvider, createBrowserRouter} from 'react-router-dom';
import Root, 
{loader as rootloader,
  action as rootAction,
} from './routes/root';
import Contact, {loader as contactLoader,   action as contactAction,} from './routes/contact';
import ErrorPage from './error-page';
import EditContact, {action as editAction} from "./routes/edit";
import { action as destroyAction } from "./routes/destroy";



const root = ReactDOM.createRoot(document.getElementById('root'));

const router = createBrowserRouter([
  {
    path: "/",
    element: <Root/>,
    errorElement: <ErrorPage/>,
    loader: rootloader,
    action: rootAction,
    children: [
      {
        path: "contacts/:contactId",
        element: <Contact />,
        loader: contactLoader,
        action: contactAction,
      },
      {
        path: "contacts/:contactId/edit",
        element: <EditContact />,
        loader: contactLoader,
        action: editAction
      },

      {
        path: "contacts/:contactId/destroy",
        action: destroyAction,
      },
    ]
  },

  
]);


root.render(
  <React.StrictMode>
   <RouterProvider router={router}/>
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals

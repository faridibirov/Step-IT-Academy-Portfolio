import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import { RouterProvider, createBrowserRouter} from 'react-router-dom';
import Root, 
{loader as rootloader,
  action as rootAction,
} from './routes/root';
import Task, {loader as taskLoader,   action as taskAction,} from './routes/task';
import ErrorPage from './error-page';
import EditTask, {action as editAction} from "./routes/edit";
import { action as destroyAction } from "./routes/destroy";

export default function Index() {
  return (
    <>
    <p id="zero-state">
      Welcome to Checklist App!
    </p>
     <p id='zero-state-under'>© 2023 Developed by Farid Dibirov. All rights reserved.</p> 
     </>
  );
}

const root = ReactDOM.createRoot(document.getElementById('root'));

const router = createBrowserRouter([
  {
    path: "/",
    element: <Root/>,
    errorElement: <ErrorPage/>,
    loader: rootloader,
    action: rootAction,
    children: [
      { index: true, element: <Index /> },
      {
       
        index: true, element: <Index />,
        path: "tasks/:taskId",
        element: <Task/>,
        loader: taskLoader,
        action: taskAction,
        
      },
      {
        path: "tasks/:taskId/edit",
        element: <EditTask />,
        loader: taskLoader,
        action: editAction
      },

      {
        path: "tasks/:taskId/destroy",
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

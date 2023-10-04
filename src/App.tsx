import React, { useEffect } from 'react';
import Paragraph from './Components/Paragraph/Paragraph';
import {useGetShipsQuery} from  './Redux/api';

function App()
{
    const {data, isLoading} = useGetShipsQuery();

useEffect(()=> {
    if (isLoading) return;
        console.log(data);
}, [isLoading]);

    return(
       <Paragraph text={isLoading ? 'Loading...' : 'Hello React'}/>
    )
}

export default App;
import {createApi, fetchBaseQuery} from '@reduxjs/toolkit/query/react';

type Ship = {
    name: string
}

type Ships = {
    data: Ship[]
}

const api = createApi(
    {
        baseQuery: fetchBaseQuery({
            baseUrl: 'https://vortex.worldofwarships.eu/api/encyclopedia/en/'
        }),
        endpoints: (build) => ({
            getShips:build.query({
                query: ()=> 'vehicles/',
                transformResponse: (response: Ships) => response.data
            })
        })
    }
);

export const {
    useGetShipsQuery
} = api;


export default api;
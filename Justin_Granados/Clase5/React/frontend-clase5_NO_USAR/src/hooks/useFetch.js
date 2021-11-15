import { useEffect, useState } from "react"

const useFetch = (url, method, params) => {
    const [state, setState] = useState(
        [{
            data: null,
            loading: true,
            error: null
        }]
    );

    useEffect(() => {
        if (method === 1) {
            fetch(url, params)
                .then(res => res.json())
                .then(data => {
                    setState([{
                        loading: false,
                        error: null,
                        data
                    }]);
                });
        } else if (method === 2) {
            fetch(url, params)
                .then(res => res.json())
                .then(data => {
                    setState([{
                        loading: false,
                        error: null,
                        data
                    }]);
                });
        } else if (method === 3) {
            fetch(url, params)
                .then(res => res.json())
                .then(data => {
                    setState([{
                        loading: false,
                        error: null,
                        data
                    }]);
                });
        } else {
            fetch(url)
                .then(res => res.json())
                .then(data => {
                    setState([{
                        loading: false,
                        error: null,
                        data
                    }]);
                });
        }
    }, [url])

    return state;
}

export default useFetch

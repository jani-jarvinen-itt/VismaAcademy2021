import React from 'react';

interface OmaKomponenttiProps {
    nimi: string;
}

interface OmaKomponenttiState {
    otsikko: string;
}

class OmaKomponentti extends React.Component<OmaKomponenttiProps, OmaKomponenttiState> {

    constructor(props: OmaKomponenttiProps) {
        super(props);

        this.state = { otsikko: "" };
        console.log("OmaKomponentti.constructor");
    }

    componentDidMount() {

        console.log("OmaKomponentti.componentDidMount");

        fetch('https://jsonplaceholder.typicode.com/todos/1')
            .then(response => response.json())
            .then(json => {
                console.log(json);

                // ruudun päivitys
                this.setState({ otsikko: json.title });
                console.log("OmaKomponentti -> setState()");
            });
    }

    render() {

        console.log("OmaKomponentti.render");

        const muuttuja = "Testitesti";

        return <>
            <h1>Moi, olen OmaKomponentti.tsx! {muuttuja}</h1>
            <p>Tervehdys {this.props.nimi}!</p>
            <p>Todo-tehtävän otsikko {this.state.otsikko}</p>
        </>;
    }
}

export default OmaKomponentti;

class Card extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            cards: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27,
                28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52],

            isShuffle: false
        };

        this.handleClick = this.handleClick.bind(this);
    }

    handleClick() {
        this.setState({ isShuffle: true });
    }

    /* A shuffle function for an array */
    shuffle(o) {
        for (
            var j, x, i = o.length;
            i;
            j = parseInt(Math.random() * i), x = o[--i], o[i] = o[j], o[j] = x
        );
        return o;
    }

    render() {
        if (this.state.isShuffle) {
            this.shuffle(this.state.cards);
        }

        return (
            <React.Fragment>
                <p id="buttonholder">
                    <button className="btn btn-primary" onClick={this.handleClick}>
                        Shuffle
                     </button>
                </p>

                <div id="cardholder">
                    {" "}
                    {this.state.cards.map((name, i) => (
                        <img
                            key={i}
                            src={(`/images/cards/${name}.png`)}
                            alt=""
                            width="76"
                            height="117"
                            hspace="2"
                        />
                    ))}
                </div>
            </React.Fragment>
        );
    }
}

ReactDOM.render(<Card/>, document.getElementById("root"));
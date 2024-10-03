module Main

open Fable.Core.JsInterop
open Feliz
open Browser.Dom

importSideEffects "./index.css"

[<ReactComponent(import="App", from="./app.tsx")>]
let App () = React.imported()

let root = ReactDOM.createRoot(document.getElementById "app")
root.render(App())

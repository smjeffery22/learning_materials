// when you do not know what type to use
// add <type> after interface name
// specify type as argument when creating variable
interface IContainer<T, A> {
  name: string;
  contents: T;
  arr?: A[];
};

const strContainer: IContainer<string, string> = {
  name: 'string container',
  contents: 'hello there',
}

const numContainer: IContainer<number, boolean> = {
  name: 'num container',
  contents: 42,
}
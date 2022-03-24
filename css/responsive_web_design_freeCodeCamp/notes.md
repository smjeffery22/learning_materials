# Responsive Web Design

## CSS Units

### Absolute Units

- Fixed size
  - Pixels (px)

### Percentage

- Mainly used for widths
- Relative to their parent (except on height)

### Relative Units

- Relative to font-size

  - _em_ and _rem_

- Relative to the viewport (browser window)
  - vw, vh, vmin, vmax

#### em

- Relative to their parent's font-size
- Font-size is an inherited property
  - If not declared, inherited from the body (i.e. _default of 16px_)

#### rem (root em)

- Relative to the "root" of the document (i.e. html element)

#### General Rule-of-Thumb

- Font-size => rem
- Padding and Margin => em
- Widths = em or percentage

## Media Queries

- To style according to different display size
  - `@media () { ... }`
    - `@media media-type and/or (media-features) { ... }`

- Media-type and media-features are optional
  - Need to include `and` to include both

### Media Type

- Target different types of media
  - Screen
    - `@media screen { ... }`

  - Print
    - `@media print { ... }`

  - Speech
    - `@media speech { ... }`

### Media Condition

- Target specific conditions within that media type

  - Widths
    - `@media (min-width: 600px) { ... }`
    - *Order* is important

  - Orientation
    - `@media (orientation: landscape) { ... }`

  - Specific Features
    - `@media (hover) { ... }`

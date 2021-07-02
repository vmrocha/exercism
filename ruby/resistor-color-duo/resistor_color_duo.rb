class ResistorColorDuo

  BANDS = {
    "black"  => 0,
    "brown"  => 1,
    "red"    => 2,
    "orange" => 3,
    "yellow" => 4,
    "green"  => 5,
    "blue"   => 6,
    "violet" => 7,
    "grey"   => 8,
    "white"  => 9
  }

  attr_accessor :bands

  def self.value(bands)
    new(bands).to_i
  end

  def initialize(bands)
    self.bands = bands.take(2)
  end

  def to_i
    bands.map(&BANDS).join.to_i
  end
  
end

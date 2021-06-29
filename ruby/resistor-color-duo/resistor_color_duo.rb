module ResistorColorDuo
  COLORS = [ "black", "brown", "red", "orange", "yellow",
              "green", "blue", "violet", "grey", "white"]
  def self.value(input)
    COLORS.index(input[0]) * 10 + COLORS.index(input[1])
  end
end
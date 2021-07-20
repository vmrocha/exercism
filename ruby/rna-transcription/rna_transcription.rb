module Complement

  COMPLEMENT = {
    'C' => 'G',
    'G' => 'C',
    'T' => 'A',
    'A' => 'U'
  }

  def self.of_dna(nucleotides)
    return nucleotides.chars.sum('') {|c| COMPLEMENT[c]}
  end

end
